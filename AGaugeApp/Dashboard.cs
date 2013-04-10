using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace AGaugeApp
{
    public partial class Dashboard : UserControl
    {
        internal struct ScaleInterval
        {
            public float ValueUpperLimit;
            public float ValueLowerLimit;
            public int MaxValue;
            public int ScaleLinesMajorStepValue;
        }

        private Collection<ScaleInterval> colScaleIntervals = new  Collection<ScaleInterval>();

        private float dblMaxVandaag;
        private float dblMaxWeek;
        public Dashboard()
        {
            InitializeComponent();
            SetTresholdValues();
        }

        private void SetTresholdValues()
        {
            dblMaxVandaag = 0;
            dblMaxWeek = 0;
            int intMaxValue = 10;
            int intScaleLinesMajorStepValue = 5;
            float dblValueUpperLimit = 10;
            float dblValueLowerLimit = 0;
            while (dblValueLowerLimit < 10000)
            {
                colScaleIntervals.Add(new ScaleInterval
                                          {
                                              ScaleLinesMajorStepValue = intScaleLinesMajorStepValue,
                                              MaxValue = intMaxValue,
                                              ValueLowerLimit = dblValueLowerLimit,
                                              ValueUpperLimit = dblValueUpperLimit
                                          });
                dblValueLowerLimit = dblValueUpperLimit;
                dblValueUpperLimit += intMaxValue;
                if((intMaxValue).ToString()[0]=='2')
                {
                    intMaxValue = (int)(intMaxValue * 2.5F);
                    intScaleLinesMajorStepValue = (int)(intScaleLinesMajorStepValue * 2.5F);
                }
                else
                {
                    intMaxValue *= 2;
                    intScaleLinesMajorStepValue *= 2;
                }
            }
        }

        public Dashboard(DashboardSectionHandler.Config objDashboardConfig)
        {
            InitializeComponent();
            SetTresholdValues();
            foreach (string key in objDashboardConfig.Items.Keys)
            {
                if (objDashboardConfig[key] != null)
                {
                    AGauge objAGauge = null;
                    switch(key)
                    {
                        case "Gauge1":
                            objAGauge = aGaugeWeekLinks;
                            break;
                        case "Gauge2":
                            objAGauge = aGaugeWeekRechts;
                            break;
                        case "Gauge3":
                            objAGauge = aGaugeVandaagLinks;
                            break;
                        case "Gauge4":
                            objAGauge = aGaugeVandaagRechts;
                            break;
                    }
                    if (objAGauge != null)
                    {
                        objAGauge.BaseArcRadius = objDashboardConfig[key].BaseArcRadius;
                        objAGauge.BaseArcStart = objDashboardConfig[key].BaseArcStart;
                        objAGauge.BaseArcSweep = objDashboardConfig[key].BaseArcSweep;
                        objAGauge.Center = objDashboardConfig[key].Center;
                        objAGauge.NeedleRadius = objDashboardConfig[key].NeedleRadius;
                        objAGauge.ScaleLinesInterInnerRadius = objDashboardConfig[key].ScaleLinesInterInnerRadius;
                        objAGauge.ScaleLinesInterInnerRadius = objDashboardConfig[key].ScaleLinesInterOuterRadius;
                        objAGauge.ScaleLinesMajorInnerRadius = objDashboardConfig[key].ScaleLinesMajorInnerRadius;
                        objAGauge.ScaleLinesMajorOuterRadius = objDashboardConfig[key].ScaleLinesMajorOuterRadius;
                        objAGauge.ScaleLinesMinorInnerRadius = objDashboardConfig[key].ScaleLinesMinorInnerRadius;
                        objAGauge.ScaleLinesMinorOuterRadius = objDashboardConfig[key].ScaleLinesMinorOuterRadius;
                        objAGauge.ScaleNumbersRadius = objDashboardConfig[key].ScaleNumbersRadius;
                        

                    }
                }
            }
        }

        private float MaxVandaag
        {
            set
            {
                dblMaxVandaag = value;
                foreach(ScaleInterval objScaleInterval in colScaleIntervals)
                {
                    if(
                        (dblMaxVandaag >= objScaleInterval.ValueLowerLimit) &&
                        (dblMaxVandaag < objScaleInterval.ValueUpperLimit))
                    {
                        aGaugeVandaagLinks.MaxValue = objScaleInterval.MaxValue;
                        aGaugeVandaagLinks.ScaleLinesMajorStepValue = objScaleInterval.ScaleLinesMajorStepValue;
                        aGaugeVandaagRechts.MaxValue = objScaleInterval.MaxValue;
                        aGaugeVandaagRechts.ScaleLinesMajorStepValue = objScaleInterval.ScaleLinesMajorStepValue;
                        break;
                    }
                }
            }
        }
        private float MaxWeek
        {
            set
            {
                dblMaxWeek = value;
                foreach (ScaleInterval objScaleInterval in colScaleIntervals)
                {
                    if (
                        (dblMaxWeek >= objScaleInterval.ValueLowerLimit) &&
                        (dblMaxWeek < objScaleInterval.ValueUpperLimit))
                    {
                        aGaugeWeekLinks.MaxValue = objScaleInterval.MaxValue;
                        aGaugeWeekLinks.ScaleLinesMajorStepValue = objScaleInterval.ScaleLinesMajorStepValue;
                        aGaugeWeekRechts.MaxValue = objScaleInterval.MaxValue;
                        aGaugeWeekRechts.ScaleLinesMajorStepValue = objScaleInterval.ScaleLinesMajorStepValue;
                        break;
                    }
                }
            }
        }
        public float InVandaag
        {
            get { return aGaugeVandaagLinks.Value; }
            set {
                aGaugeVandaagLinks.Value = value;
                lblVandaagLinks.Text = value.ToString("000");
                if (UitVandaag <= value)
                {
                    MaxVandaag = value;
                }
            }
        }

        public float UitVandaag
        {
            get { return aGaugeVandaagRechts.Value; }
            set {
                aGaugeVandaagRechts.Value = value;
                lblVandaagRechts.Text = value.ToString("000");
                if (InVandaag <= value)
                {
                    MaxVandaag = value;
                }
            }
        }

        public float InWeek
        {
            get { return aGaugeWeekLinks.Value; }
            set {
                aGaugeWeekLinks.Value = value;
                lblWeekLinks.Text = value.ToString("000");
                if (UitWeek <= value)
                {
                    MaxWeek = value;
                }
            }
        }

        public float UitWeek
        {
            get { return aGaugeWeekRechts.Value; }
            set {
                aGaugeWeekRechts.Value = value;
                lblWeekRechts.Text = value.ToString("000");
                if (InWeek <= value)
                {
                    MaxWeek = value;
                }
            }
        }

        public float Totaal
        {
            get { return aGaugeTotaal.Value; }
            set { aGaugeTotaal.Value = value;
                lblTotaal.Text = value.ToString("000");
            }
        }
        private void aGaugeInWeek_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void aGaugeUitVandaag_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void aGaugeInVandaag_ValueInRangeChanged(object sender, AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblVandaagRechts_Click(object sender, EventArgs e)
        {

        }
    }
}