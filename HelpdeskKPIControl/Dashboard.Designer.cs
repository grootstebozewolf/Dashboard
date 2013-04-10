namespace HelpdeskKPIControl
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aGaugeTotaal = new AGaugeApp.AGauge();
            this.aGaugeInWeek = new AGaugeApp.AGauge();
            this.aGaugeUitWeek = new AGaugeApp.AGauge();
            this.aGaugeInVandaag = new AGaugeApp.AGauge();
            this.aGaugeUitVandaag = new AGaugeApp.AGauge();
            this.SuspendLayout();
            // 
            // aGaugeTotaal
            // 
            this.aGaugeTotaal.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeTotaal.BaseArcRadius = 130;
            this.aGaugeTotaal.BaseArcStart = 135;
            this.aGaugeTotaal.BaseArcSweep = 270;
            this.aGaugeTotaal.BaseArcWidth = 2;
            this.aGaugeTotaal.Cap_Idx = ((byte)(2));
            this.aGaugeTotaal.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeTotaal.CapPosition = new System.Drawing.Point(116, 200);
            this.aGaugeTotaal.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(125, 100),
        new System.Drawing.Point(116, 200),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeTotaal.CapsText = new string[] {
        "",
        "Incidenten",
        "Totaal Open",
        "",
        ""};
            this.aGaugeTotaal.CapText = "Totaal Open";
            this.aGaugeTotaal.Center = new System.Drawing.Point(170, 170);
            this.aGaugeTotaal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeTotaal.Location = new System.Drawing.Point(125, 21);
            this.aGaugeTotaal.MaxValue = 300F;
            this.aGaugeTotaal.MinValue = 0F;
            this.aGaugeTotaal.Name = "aGaugeTotaal";
            this.aGaugeTotaal.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Yellow;
            this.aGaugeTotaal.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeTotaal.NeedleRadius = 130;
            this.aGaugeTotaal.NeedleType = 0;
            this.aGaugeTotaal.NeedleWidth = 5;
            this.aGaugeTotaal.Range_Idx = ((byte)(1));
            this.aGaugeTotaal.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aGaugeTotaal.RangeEnabled = true;
            this.aGaugeTotaal.RangeEndValue = 290F;
            this.aGaugeTotaal.RangeInnerRadius = 100;
            this.aGaugeTotaal.RangeOuterRadius = 130;
            this.aGaugeTotaal.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeTotaal.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGaugeTotaal.RangesEndValue = new float[] {
        120F,
        180F,
        300F,
        0F,
        0F};
            this.aGaugeTotaal.RangesInnerRadius = new int[] {
        120,
        120,
        120,
        70,
        70};
            this.aGaugeTotaal.RangesOuterRadius = new int[] {
        130,
        130,
        130,
        80,
        80};
            this.aGaugeTotaal.RangesStartValue = new float[] {
        0F,
        120F,
        180F,
        0F,
        0F};
            this.aGaugeTotaal.RangeStartValue = 120F;
            this.aGaugeTotaal.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeTotaal.ScaleLinesInterInnerRadius = 130;
            this.aGaugeTotaal.ScaleLinesInterOuterRadius = 140;
            this.aGaugeTotaal.ScaleLinesInterWidth = 2;
            this.aGaugeTotaal.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeTotaal.ScaleLinesMajorInnerRadius = 130;
            this.aGaugeTotaal.ScaleLinesMajorOuterRadius = 142;
            this.aGaugeTotaal.ScaleLinesMajorStepValue = 50F;
            this.aGaugeTotaal.ScaleLinesMajorWidth = 3;
            this.aGaugeTotaal.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGaugeTotaal.ScaleLinesMinorInnerRadius = 130;
            this.aGaugeTotaal.ScaleLinesMinorNumOf = 9;
            this.aGaugeTotaal.ScaleLinesMinorOuterRadius = 140;
            this.aGaugeTotaal.ScaleLinesMinorWidth = 1;
            this.aGaugeTotaal.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeTotaal.ScaleNumbersFormat = null;
            this.aGaugeTotaal.ScaleNumbersRadius = 160;
            this.aGaugeTotaal.ScaleNumbersRotation = 0;
            this.aGaugeTotaal.ScaleNumbersStartScaleLine = 0;
            this.aGaugeTotaal.ScaleNumbersStepScaleLines = 1;
            this.aGaugeTotaal.Size = new System.Drawing.Size(345, 299);
            this.aGaugeTotaal.TabIndex = 21;
            this.aGaugeTotaal.Text = "aGaugeTotaal";
            this.aGaugeTotaal.Value = 269F;
            // 
            // aGaugeInWeek
            // 
            this.aGaugeInWeek.BackColor = System.Drawing.SystemColors.Control;
            this.aGaugeInWeek.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeInWeek.BaseArcRadius = 40;
            this.aGaugeInWeek.BaseArcStart = 0;
            this.aGaugeInWeek.BaseArcSweep = -90;
            this.aGaugeInWeek.BaseArcWidth = 2;
            this.aGaugeInWeek.Cap_Idx = ((byte)(1));
            this.aGaugeInWeek.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeInWeek.CapPosition = new System.Drawing.Point(10, 10);
            this.aGaugeInWeek.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeInWeek.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeInWeek.CapText = "";
            this.aGaugeInWeek.Center = new System.Drawing.Point(15, 70);
            this.aGaugeInWeek.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeInWeek.Location = new System.Drawing.Point(125, 353);
            this.aGaugeInWeek.MaxValue = 100F;
            this.aGaugeInWeek.MinValue = 0F;
            this.aGaugeInWeek.Name = "aGaugeInWeek";
            this.aGaugeInWeek.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGaugeInWeek.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeInWeek.NeedleRadius = 40;
            this.aGaugeInWeek.NeedleType = 0;
            this.aGaugeInWeek.NeedleWidth = 2;
            this.aGaugeInWeek.Range_Idx = ((byte)(0));
            this.aGaugeInWeek.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeInWeek.RangeEnabled = false;
            this.aGaugeInWeek.RangeEndValue = 300F;
            this.aGaugeInWeek.RangeInnerRadius = 70;
            this.aGaugeInWeek.RangeOuterRadius = 80;
            this.aGaugeInWeek.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeInWeek.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeInWeek.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeInWeek.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGaugeInWeek.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGaugeInWeek.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeInWeek.RangeStartValue = -100F;
            this.aGaugeInWeek.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGaugeInWeek.ScaleLinesInterInnerRadius = 45;
            this.aGaugeInWeek.ScaleLinesInterOuterRadius = 50;
            this.aGaugeInWeek.ScaleLinesInterWidth = 2;
            this.aGaugeInWeek.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGaugeInWeek.ScaleLinesMajorInnerRadius = 40;
            this.aGaugeInWeek.ScaleLinesMajorOuterRadius = 50;
            this.aGaugeInWeek.ScaleLinesMajorStepValue = 50F;
            this.aGaugeInWeek.ScaleLinesMajorWidth = 2;
            this.aGaugeInWeek.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGaugeInWeek.ScaleLinesMinorInnerRadius = 45;
            this.aGaugeInWeek.ScaleLinesMinorNumOf = 9;
            this.aGaugeInWeek.ScaleLinesMinorOuterRadius = 50;
            this.aGaugeInWeek.ScaleLinesMinorWidth = 2;
            this.aGaugeInWeek.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGaugeInWeek.ScaleNumbersFormat = null;
            this.aGaugeInWeek.ScaleNumbersRadius = 62;
            this.aGaugeInWeek.ScaleNumbersRotation = 90;
            this.aGaugeInWeek.ScaleNumbersStartScaleLine = 1;
            this.aGaugeInWeek.ScaleNumbersStepScaleLines = 2;
            this.aGaugeInWeek.Size = new System.Drawing.Size(85, 93);
            this.aGaugeInWeek.TabIndex = 18;
            this.aGaugeInWeek.Text = "aGaugeInWeek";
            this.aGaugeInWeek.Value = 0F;
            // 
            // aGaugeUitWeek
            // 
            this.aGaugeUitWeek.BackColor = System.Drawing.SystemColors.Control;
            this.aGaugeUitWeek.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeUitWeek.BaseArcRadius = 40;
            this.aGaugeUitWeek.BaseArcStart = 180;
            this.aGaugeUitWeek.BaseArcSweep = 90;
            this.aGaugeUitWeek.BaseArcWidth = 2;
            this.aGaugeUitWeek.Cap_Idx = ((byte)(1));
            this.aGaugeUitWeek.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeUitWeek.CapPosition = new System.Drawing.Point(20, 75);
            this.aGaugeUitWeek.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeUitWeek.CapsText = new string[] {
        "",
        "Week",
        "",
        "",
        ""};
            this.aGaugeUitWeek.CapText = "Week";
            this.aGaugeUitWeek.Center = new System.Drawing.Point(70, 70);
            this.aGaugeUitWeek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeUitWeek.Location = new System.Drawing.Point(28, 353);
            this.aGaugeUitWeek.MaxValue = 100F;
            this.aGaugeUitWeek.MinValue = 0F;
            this.aGaugeUitWeek.Name = "aGaugeUitWeek";
            this.aGaugeUitWeek.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGaugeUitWeek.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeUitWeek.NeedleRadius = 40;
            this.aGaugeUitWeek.NeedleType = 0;
            this.aGaugeUitWeek.NeedleWidth = 2;
            this.aGaugeUitWeek.Range_Idx = ((byte)(0));
            this.aGaugeUitWeek.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeUitWeek.RangeEnabled = false;
            this.aGaugeUitWeek.RangeEndValue = 300F;
            this.aGaugeUitWeek.RangeInnerRadius = 70;
            this.aGaugeUitWeek.RangeOuterRadius = 80;
            this.aGaugeUitWeek.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeUitWeek.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeUitWeek.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeUitWeek.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGaugeUitWeek.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGaugeUitWeek.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeUitWeek.RangeStartValue = -100F;
            this.aGaugeUitWeek.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeUitWeek.ScaleLinesInterInnerRadius = 42;
            this.aGaugeUitWeek.ScaleLinesInterOuterRadius = 50;
            this.aGaugeUitWeek.ScaleLinesInterWidth = 2;
            this.aGaugeUitWeek.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeUitWeek.ScaleLinesMajorInnerRadius = 40;
            this.aGaugeUitWeek.ScaleLinesMajorOuterRadius = 50;
            this.aGaugeUitWeek.ScaleLinesMajorStepValue = 50F;
            this.aGaugeUitWeek.ScaleLinesMajorWidth = 2;
            this.aGaugeUitWeek.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGaugeUitWeek.ScaleLinesMinorInnerRadius = 43;
            this.aGaugeUitWeek.ScaleLinesMinorNumOf = 9;
            this.aGaugeUitWeek.ScaleLinesMinorOuterRadius = 50;
            this.aGaugeUitWeek.ScaleLinesMinorWidth = 2;
            this.aGaugeUitWeek.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeUitWeek.ScaleNumbersFormat = null;
            this.aGaugeUitWeek.ScaleNumbersRadius = 62;
            this.aGaugeUitWeek.ScaleNumbersRotation = 90;
            this.aGaugeUitWeek.ScaleNumbersStartScaleLine = 1;
            this.aGaugeUitWeek.ScaleNumbersStepScaleLines = 2;
            this.aGaugeUitWeek.Size = new System.Drawing.Size(91, 108);
            this.aGaugeUitWeek.TabIndex = 17;
            this.aGaugeUitWeek.Text = "aGaugeUitWeek";
            this.aGaugeUitWeek.Value = 0F;
            // 
            // aGaugeInVandaag
            // 
            this.aGaugeInVandaag.BackColor = System.Drawing.SystemColors.Control;
            this.aGaugeInVandaag.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeInVandaag.BaseArcRadius = 40;
            this.aGaugeInVandaag.BaseArcStart = 0;
            this.aGaugeInVandaag.BaseArcSweep = -90;
            this.aGaugeInVandaag.BaseArcWidth = 2;
            this.aGaugeInVandaag.Cap_Idx = ((byte)(1));
            this.aGaugeInVandaag.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeInVandaag.CapPosition = new System.Drawing.Point(10, 10);
            this.aGaugeInVandaag.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeInVandaag.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeInVandaag.CapText = "";
            this.aGaugeInVandaag.Center = new System.Drawing.Point(15, 70);
            this.aGaugeInVandaag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeInVandaag.Location = new System.Drawing.Point(476, 353);
            this.aGaugeInVandaag.MaxValue = 100F;
            this.aGaugeInVandaag.MinValue = 0F;
            this.aGaugeInVandaag.Name = "aGaugeInVandaag";
            this.aGaugeInVandaag.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGaugeInVandaag.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeInVandaag.NeedleRadius = 40;
            this.aGaugeInVandaag.NeedleType = 0;
            this.aGaugeInVandaag.NeedleWidth = 2;
            this.aGaugeInVandaag.Range_Idx = ((byte)(0));
            this.aGaugeInVandaag.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeInVandaag.RangeEnabled = false;
            this.aGaugeInVandaag.RangeEndValue = 300F;
            this.aGaugeInVandaag.RangeInnerRadius = 70;
            this.aGaugeInVandaag.RangeOuterRadius = 80;
            this.aGaugeInVandaag.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeInVandaag.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeInVandaag.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeInVandaag.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGaugeInVandaag.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGaugeInVandaag.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeInVandaag.RangeStartValue = -100F;
            this.aGaugeInVandaag.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGaugeInVandaag.ScaleLinesInterInnerRadius = 45;
            this.aGaugeInVandaag.ScaleLinesInterOuterRadius = 50;
            this.aGaugeInVandaag.ScaleLinesInterWidth = 2;
            this.aGaugeInVandaag.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGaugeInVandaag.ScaleLinesMajorInnerRadius = 40;
            this.aGaugeInVandaag.ScaleLinesMajorOuterRadius = 50;
            this.aGaugeInVandaag.ScaleLinesMajorStepValue = 50F;
            this.aGaugeInVandaag.ScaleLinesMajorWidth = 2;
            this.aGaugeInVandaag.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGaugeInVandaag.ScaleLinesMinorInnerRadius = 45;
            this.aGaugeInVandaag.ScaleLinesMinorNumOf = 9;
            this.aGaugeInVandaag.ScaleLinesMinorOuterRadius = 50;
            this.aGaugeInVandaag.ScaleLinesMinorWidth = 2;
            this.aGaugeInVandaag.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGaugeInVandaag.ScaleNumbersFormat = null;
            this.aGaugeInVandaag.ScaleNumbersRadius = 62;
            this.aGaugeInVandaag.ScaleNumbersRotation = 90;
            this.aGaugeInVandaag.ScaleNumbersStartScaleLine = 1;
            this.aGaugeInVandaag.ScaleNumbersStepScaleLines = 2;
            this.aGaugeInVandaag.Size = new System.Drawing.Size(85, 93);
            this.aGaugeInVandaag.TabIndex = 16;
            this.aGaugeInVandaag.Text = "aGaugeInVandaag";
            this.aGaugeInVandaag.Value = 0F;
            // 
            // aGaugeUitVandaag
            // 
            this.aGaugeUitVandaag.BackColor = System.Drawing.SystemColors.Control;
            this.aGaugeUitVandaag.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeUitVandaag.BaseArcRadius = 40;
            this.aGaugeUitVandaag.BaseArcStart = 180;
            this.aGaugeUitVandaag.BaseArcSweep = 90;
            this.aGaugeUitVandaag.BaseArcWidth = 2;
            this.aGaugeUitVandaag.Cap_Idx = ((byte)(1));
            this.aGaugeUitVandaag.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeUitVandaag.CapPosition = new System.Drawing.Point(20, 75);
            this.aGaugeUitVandaag.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeUitVandaag.CapsText = new string[] {
        "",
        "Vandaag",
        "",
        "",
        ""};
            this.aGaugeUitVandaag.CapText = "Vandaag";
            this.aGaugeUitVandaag.Center = new System.Drawing.Point(70, 70);
            this.aGaugeUitVandaag.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeUitVandaag.Location = new System.Drawing.Point(379, 353);
            this.aGaugeUitVandaag.MaxValue = 100F;
            this.aGaugeUitVandaag.MinValue = 0F;
            this.aGaugeUitVandaag.Name = "aGaugeUitVandaag";
            this.aGaugeUitVandaag.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGaugeUitVandaag.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeUitVandaag.NeedleRadius = 40;
            this.aGaugeUitVandaag.NeedleType = 0;
            this.aGaugeUitVandaag.NeedleWidth = 2;
            this.aGaugeUitVandaag.Range_Idx = ((byte)(0));
            this.aGaugeUitVandaag.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeUitVandaag.RangeEnabled = false;
            this.aGaugeUitVandaag.RangeEndValue = 300F;
            this.aGaugeUitVandaag.RangeInnerRadius = 70;
            this.aGaugeUitVandaag.RangeOuterRadius = 80;
            this.aGaugeUitVandaag.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeUitVandaag.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeUitVandaag.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeUitVandaag.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGaugeUitVandaag.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGaugeUitVandaag.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeUitVandaag.RangeStartValue = -100F;
            this.aGaugeUitVandaag.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeUitVandaag.ScaleLinesInterInnerRadius = 42;
            this.aGaugeUitVandaag.ScaleLinesInterOuterRadius = 50;
            this.aGaugeUitVandaag.ScaleLinesInterWidth = 2;
            this.aGaugeUitVandaag.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeUitVandaag.ScaleLinesMajorInnerRadius = 40;
            this.aGaugeUitVandaag.ScaleLinesMajorOuterRadius = 50;
            this.aGaugeUitVandaag.ScaleLinesMajorStepValue = 50F;
            this.aGaugeUitVandaag.ScaleLinesMajorWidth = 2;
            this.aGaugeUitVandaag.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGaugeUitVandaag.ScaleLinesMinorInnerRadius = 43;
            this.aGaugeUitVandaag.ScaleLinesMinorNumOf = 9;
            this.aGaugeUitVandaag.ScaleLinesMinorOuterRadius = 50;
            this.aGaugeUitVandaag.ScaleLinesMinorWidth = 2;
            this.aGaugeUitVandaag.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeUitVandaag.ScaleNumbersFormat = null;
            this.aGaugeUitVandaag.ScaleNumbersRadius = 62;
            this.aGaugeUitVandaag.ScaleNumbersRotation = 90;
            this.aGaugeUitVandaag.ScaleNumbersStartScaleLine = 1;
            this.aGaugeUitVandaag.ScaleNumbersStepScaleLines = 2;
            this.aGaugeUitVandaag.Size = new System.Drawing.Size(91, 108);
            this.aGaugeUitVandaag.TabIndex = 15;
            this.aGaugeUitVandaag.Text = "aGaugeUitVandaag";
            this.aGaugeUitVandaag.Value = 0F;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aGaugeTotaal);
            this.Controls.Add(this.aGaugeInWeek);
            this.Controls.Add(this.aGaugeUitWeek);
            this.Controls.Add(this.aGaugeInVandaag);
            this.Controls.Add(this.aGaugeUitVandaag);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(588, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private AGaugeApp.AGauge aGaugeInVandaag;
        private AGaugeApp.AGauge aGaugeUitVandaag;
        private AGaugeApp.AGauge aGaugeUitWeek;
        private AGaugeApp.AGauge aGaugeTotaal;
        private AGaugeApp.AGauge aGaugeInWeek;

    }
}
