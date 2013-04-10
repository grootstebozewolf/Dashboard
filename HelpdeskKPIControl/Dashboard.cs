using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelpdeskKPIControl
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public float InVandaag
        {
            get { return aGaugeInVandaag.Value; }
            set { aGaugeInVandaag.Value = value; }
        }

        public float UitVandaag
        {
            get { return aGaugeUitVandaag.Value; }
            set { aGaugeUitVandaag.Value = value; }
        }

        public float InWeek
        {
            get { return aGaugeInWeek.Value; }
            set { aGaugeInWeek.Value = value; }
        }

        public float UitWeek
        {
            get { return aGaugeUitWeek.Value; }
            set { aGaugeUitWeek.Value = value; }
        }

        public float Totaal
        {
            get { return aGaugeTotaal.Value; }
            set { aGaugeTotaal.Value = value; }
        }
    }
}
