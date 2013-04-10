namespace AGaugeApp
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
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblWeekLinks = new System.Windows.Forms.Label();
            this.lblWeekRechts = new System.Windows.Forms.Label();
            this.lblVandaagLinks = new System.Windows.Forms.Label();
            this.lblVandaagRechts = new System.Windows.Forms.Label();
            this.aGaugeTotaal = new AGaugeApp.AGauge();
            this.aGaugeWeekRechts = new AGaugeApp.AGauge();
            this.aGaugeWeekLinks = new AGaugeApp.AGauge();
            this.aGaugeVandaagRechts = new AGaugeApp.AGauge();
            this.aGaugeVandaagLinks = new AGaugeApp.AGauge();
            this.SuspendLayout();
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.BackColor = System.Drawing.Color.Black;
            this.lblTotaal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotaal.Font = new System.Drawing.Font("Digital Readout", 70.75F);
            this.lblTotaal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotaal.Location = new System.Drawing.Point(214, 288);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(163, 84);
            this.lblTotaal.TabIndex = 22;
            this.lblTotaal.Text = "000";
            // 
            // lblWeekLinks
            // 
            this.lblWeekLinks.AutoSize = true;
            this.lblWeekLinks.BackColor = System.Drawing.Color.Black;
            this.lblWeekLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeekLinks.Font = new System.Drawing.Font("Digital Readout", 50.75F);
            this.lblWeekLinks.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWeekLinks.Location = new System.Drawing.Point(9, 510);
            this.lblWeekLinks.Name = "lblWeekLinks";
            this.lblWeekLinks.Size = new System.Drawing.Size(117, 60);
            this.lblWeekLinks.TabIndex = 23;
            this.lblWeekLinks.Text = "000";
            // 
            // lblWeekRechts
            // 
            this.lblWeekRechts.AutoSize = true;
            this.lblWeekRechts.BackColor = System.Drawing.Color.Black;
            this.lblWeekRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeekRechts.Font = new System.Drawing.Font("Digital Readout", 50.75F);
            this.lblWeekRechts.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWeekRechts.Location = new System.Drawing.Point(132, 510);
            this.lblWeekRechts.Name = "lblWeekRechts";
            this.lblWeekRechts.Size = new System.Drawing.Size(117, 60);
            this.lblWeekRechts.TabIndex = 24;
            this.lblWeekRechts.Text = "000";
            // 
            // lblVandaagLinks
            // 
            this.lblVandaagLinks.AutoSize = true;
            this.lblVandaagLinks.BackColor = System.Drawing.Color.Black;
            this.lblVandaagLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVandaagLinks.Font = new System.Drawing.Font("Digital Readout", 50.75F);
            this.lblVandaagLinks.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblVandaagLinks.Location = new System.Drawing.Point(338, 509);
            this.lblVandaagLinks.Name = "lblVandaagLinks";
            this.lblVandaagLinks.Size = new System.Drawing.Size(117, 60);
            this.lblVandaagLinks.TabIndex = 25;
            this.lblVandaagLinks.Text = "000";
            this.lblVandaagLinks.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblVandaagRechts
            // 
            this.lblVandaagRechts.AutoSize = true;
            this.lblVandaagRechts.BackColor = System.Drawing.Color.Black;
            this.lblVandaagRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVandaagRechts.Font = new System.Drawing.Font("Digital Readout", 50.75F);
            this.lblVandaagRechts.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblVandaagRechts.Location = new System.Drawing.Point(461, 509);
            this.lblVandaagRechts.Name = "lblVandaagRechts";
            this.lblVandaagRechts.Size = new System.Drawing.Size(117, 60);
            this.lblVandaagRechts.TabIndex = 26;
            this.lblVandaagRechts.Text = "000";
            this.lblVandaagRechts.Click += new System.EventHandler(this.lblVandaagRechts_Click);
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
            this.aGaugeTotaal.MaxValue = 250F;
            this.aGaugeTotaal.MinValue = 0F;
            this.aGaugeTotaal.Name = "aGaugeTotaal";
            this.aGaugeTotaal.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Yellow;
            this.aGaugeTotaal.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGaugeTotaal.NeedleRadius = 130;
            this.aGaugeTotaal.NeedleType = 0;
            this.aGaugeTotaal.NeedleWidth = 5;
            this.aGaugeTotaal.Range_Idx = ((byte)(2));
            this.aGaugeTotaal.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGaugeTotaal.RangeEnabled = true;
            this.aGaugeTotaal.RangeEndValue = 250F;
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
        100F,
        150F,
        250F,
        0F,
        0F};
            this.aGaugeTotaal.RangesInnerRadius = new int[] {
        100,
        100,
        100,
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
        100F,
        150F,
        0F,
        0F};
            this.aGaugeTotaal.RangeStartValue = 150F;
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
            // aGaugeWeekRechts
            // 
            this.aGaugeWeekRechts.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeWeekRechts.BaseArcRadius = 50;
            this.aGaugeWeekRechts.BaseArcStart = 180;
            this.aGaugeWeekRechts.BaseArcSweep = 90;
            this.aGaugeWeekRechts.BaseArcWidth = 2;
            this.aGaugeWeekRechts.Cap_Idx = ((byte)(1));
            this.aGaugeWeekRechts.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeWeekRechts.CapPosition = new System.Drawing.Point(10, 10);
            this.aGaugeWeekRechts.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeWeekRechts.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeWeekRechts.CapText = "";
            this.aGaugeWeekRechts.Center = new System.Drawing.Point(80, 80);
            this.aGaugeWeekRechts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeWeekRechts.Location = new System.Drawing.Point(132, 413);
            this.aGaugeWeekRechts.MaxValue = 100F;
            this.aGaugeWeekRechts.MinValue = 0F;
            this.aGaugeWeekRechts.Name = "aGaugeWeekRechts";
            this.aGaugeWeekRechts.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGaugeWeekRechts.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeWeekRechts.NeedleRadius = 50;
            this.aGaugeWeekRechts.NeedleType = 0;
            this.aGaugeWeekRechts.NeedleWidth = 2;
            this.aGaugeWeekRechts.Range_Idx = ((byte)(0));
            this.aGaugeWeekRechts.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeWeekRechts.RangeEnabled = false;
            this.aGaugeWeekRechts.RangeEndValue = 300F;
            this.aGaugeWeekRechts.RangeInnerRadius = 80;
            this.aGaugeWeekRechts.RangeOuterRadius = 100;
            this.aGaugeWeekRechts.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeWeekRechts.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeWeekRechts.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeWeekRechts.RangesInnerRadius = new int[] {
        80,
        10,
        80,
        80,
        80};
            this.aGaugeWeekRechts.RangesOuterRadius = new int[] {
        100,
        50,
        100,
        100,
        100};
            this.aGaugeWeekRechts.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeWeekRechts.RangeStartValue = -100F;
            this.aGaugeWeekRechts.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGaugeWeekRechts.ScaleLinesInterInnerRadius = 55;
            this.aGaugeWeekRechts.ScaleLinesInterOuterRadius = 60;
            this.aGaugeWeekRechts.ScaleLinesInterWidth = 2;
            this.aGaugeWeekRechts.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGaugeWeekRechts.ScaleLinesMajorInnerRadius = 50;
            this.aGaugeWeekRechts.ScaleLinesMajorOuterRadius = 60;
            this.aGaugeWeekRechts.ScaleLinesMajorStepValue = 50F;
            this.aGaugeWeekRechts.ScaleLinesMajorWidth = 2;
            this.aGaugeWeekRechts.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGaugeWeekRechts.ScaleLinesMinorInnerRadius = 55;
            this.aGaugeWeekRechts.ScaleLinesMinorNumOf = 9;
            this.aGaugeWeekRechts.ScaleLinesMinorOuterRadius = 60;
            this.aGaugeWeekRechts.ScaleLinesMinorWidth = 2;
            this.aGaugeWeekRechts.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGaugeWeekRechts.ScaleNumbersFormat = null;
            this.aGaugeWeekRechts.ScaleNumbersRadius = 72;
            this.aGaugeWeekRechts.ScaleNumbersRotation = 90;
            this.aGaugeWeekRechts.ScaleNumbersStartScaleLine = 1;
            this.aGaugeWeekRechts.ScaleNumbersStepScaleLines = 2;
            this.aGaugeWeekRechts.Size = new System.Drawing.Size(117, 104);
            this.aGaugeWeekRechts.TabIndex = 18;
            this.aGaugeWeekRechts.Text = "aGaugeInWeek";
            this.aGaugeWeekRechts.Value = 0F;
            this.aGaugeWeekRechts.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGaugeInWeek_ValueInRangeChanged);
            // 
            // aGaugeWeekLinks
            // 
            this.aGaugeWeekLinks.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeWeekLinks.BaseArcRadius = 50;
            this.aGaugeWeekLinks.BaseArcStart = 0;
            this.aGaugeWeekLinks.BaseArcSweep = -90;
            this.aGaugeWeekLinks.BaseArcWidth = 2;
            this.aGaugeWeekLinks.Cap_Idx = ((byte)(1));
            this.aGaugeWeekLinks.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeWeekLinks.CapPosition = new System.Drawing.Point(20, 10);
            this.aGaugeWeekLinks.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeWeekLinks.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeWeekLinks.CapText = "";
            this.aGaugeWeekLinks.Center = new System.Drawing.Point(15, 80);
            this.aGaugeWeekLinks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeWeekLinks.Location = new System.Drawing.Point(9, 413);
            this.aGaugeWeekLinks.MaxValue = 100F;
            this.aGaugeWeekLinks.MinValue = 0F;
            this.aGaugeWeekLinks.Name = "aGaugeWeekLinks";
            this.aGaugeWeekLinks.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGaugeWeekLinks.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeWeekLinks.NeedleRadius = 50;
            this.aGaugeWeekLinks.NeedleType = 0;
            this.aGaugeWeekLinks.NeedleWidth = 2;
            this.aGaugeWeekLinks.Range_Idx = ((byte)(0));
            this.aGaugeWeekLinks.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeWeekLinks.RangeEnabled = false;
            this.aGaugeWeekLinks.RangeEndValue = 300F;
            this.aGaugeWeekLinks.RangeInnerRadius = 80;
            this.aGaugeWeekLinks.RangeOuterRadius = 100;
            this.aGaugeWeekLinks.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeWeekLinks.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeWeekLinks.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeWeekLinks.RangesInnerRadius = new int[] {
        80,
        10,
        80,
        80,
        80};
            this.aGaugeWeekLinks.RangesOuterRadius = new int[] {
        100,
        50,
        100,
        100,
        100};
            this.aGaugeWeekLinks.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeWeekLinks.RangeStartValue = -100F;
            this.aGaugeWeekLinks.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeWeekLinks.ScaleLinesInterInnerRadius = 55;
            this.aGaugeWeekLinks.ScaleLinesInterOuterRadius = 60;
            this.aGaugeWeekLinks.ScaleLinesInterWidth = 2;
            this.aGaugeWeekLinks.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeWeekLinks.ScaleLinesMajorInnerRadius = 50;
            this.aGaugeWeekLinks.ScaleLinesMajorOuterRadius = 60;
            this.aGaugeWeekLinks.ScaleLinesMajorStepValue = 50F;
            this.aGaugeWeekLinks.ScaleLinesMajorWidth = 2;
            this.aGaugeWeekLinks.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGaugeWeekLinks.ScaleLinesMinorInnerRadius = 55;
            this.aGaugeWeekLinks.ScaleLinesMinorNumOf = 9;
            this.aGaugeWeekLinks.ScaleLinesMinorOuterRadius = 60;
            this.aGaugeWeekLinks.ScaleLinesMinorWidth = 2;
            this.aGaugeWeekLinks.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeWeekLinks.ScaleNumbersFormat = null;
            this.aGaugeWeekLinks.ScaleNumbersRadius = 72;
            this.aGaugeWeekLinks.ScaleNumbersRotation = 90;
            this.aGaugeWeekLinks.ScaleNumbersStartScaleLine = 1;
            this.aGaugeWeekLinks.ScaleNumbersStepScaleLines = 2;
            this.aGaugeWeekLinks.Size = new System.Drawing.Size(117, 86);
            this.aGaugeWeekLinks.TabIndex = 17;
            this.aGaugeWeekLinks.Text = "aGaugeUitWeek";
            this.aGaugeWeekLinks.Value = 0F;
            // 
            // aGaugeVandaagRechts
            // 
            this.aGaugeVandaagRechts.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeVandaagRechts.BaseArcRadius = 50;
            this.aGaugeVandaagRechts.BaseArcStart = 180;
            this.aGaugeVandaagRechts.BaseArcSweep = 90;
            this.aGaugeVandaagRechts.BaseArcWidth = 2;
            this.aGaugeVandaagRechts.Cap_Idx = ((byte)(1));
            this.aGaugeVandaagRechts.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeVandaagRechts.CapPosition = new System.Drawing.Point(10, 10);
            this.aGaugeVandaagRechts.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeVandaagRechts.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeVandaagRechts.CapText = "";
            this.aGaugeVandaagRechts.Center = new System.Drawing.Point(80, 80);
            this.aGaugeVandaagRechts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeVandaagRechts.Location = new System.Drawing.Point(461, 413);
            this.aGaugeVandaagRechts.MaxValue = 100F;
            this.aGaugeVandaagRechts.MinValue = 0F;
            this.aGaugeVandaagRechts.Name = "aGaugeVandaagRechts";
            this.aGaugeVandaagRechts.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGaugeVandaagRechts.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeVandaagRechts.NeedleRadius = 50;
            this.aGaugeVandaagRechts.NeedleType = 0;
            this.aGaugeVandaagRechts.NeedleWidth = 2;
            this.aGaugeVandaagRechts.Range_Idx = ((byte)(0));
            this.aGaugeVandaagRechts.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeVandaagRechts.RangeEnabled = false;
            this.aGaugeVandaagRechts.RangeEndValue = 300F;
            this.aGaugeVandaagRechts.RangeInnerRadius = 80;
            this.aGaugeVandaagRechts.RangeOuterRadius = 100;
            this.aGaugeVandaagRechts.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeVandaagRechts.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeVandaagRechts.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeVandaagRechts.RangesInnerRadius = new int[] {
        80,
        10,
        80,
        80,
        80};
            this.aGaugeVandaagRechts.RangesOuterRadius = new int[] {
        100,
        50,
        100,
        100,
        100};
            this.aGaugeVandaagRechts.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeVandaagRechts.RangeStartValue = -100F;
            this.aGaugeVandaagRechts.ScaleLinesInterColor = System.Drawing.Color.DarkRed;
            this.aGaugeVandaagRechts.ScaleLinesInterInnerRadius = 55;
            this.aGaugeVandaagRechts.ScaleLinesInterOuterRadius = 60;
            this.aGaugeVandaagRechts.ScaleLinesInterWidth = 2;
            this.aGaugeVandaagRechts.ScaleLinesMajorColor = System.Drawing.Color.SaddleBrown;
            this.aGaugeVandaagRechts.ScaleLinesMajorInnerRadius = 50;
            this.aGaugeVandaagRechts.ScaleLinesMajorOuterRadius = 60;
            this.aGaugeVandaagRechts.ScaleLinesMajorStepValue = 50F;
            this.aGaugeVandaagRechts.ScaleLinesMajorWidth = 2;
            this.aGaugeVandaagRechts.ScaleLinesMinorColor = System.Drawing.Color.DarkRed;
            this.aGaugeVandaagRechts.ScaleLinesMinorInnerRadius = 55;
            this.aGaugeVandaagRechts.ScaleLinesMinorNumOf = 9;
            this.aGaugeVandaagRechts.ScaleLinesMinorOuterRadius = 60;
            this.aGaugeVandaagRechts.ScaleLinesMinorWidth = 2;
            this.aGaugeVandaagRechts.ScaleNumbersColor = System.Drawing.Color.Maroon;
            this.aGaugeVandaagRechts.ScaleNumbersFormat = null;
            this.aGaugeVandaagRechts.ScaleNumbersRadius = 72;
            this.aGaugeVandaagRechts.ScaleNumbersRotation = 90;
            this.aGaugeVandaagRechts.ScaleNumbersStartScaleLine = 1;
            this.aGaugeVandaagRechts.ScaleNumbersStepScaleLines = 2;
            this.aGaugeVandaagRechts.Size = new System.Drawing.Size(117, 104);
            this.aGaugeVandaagRechts.TabIndex = 16;
            this.aGaugeVandaagRechts.Text = "aGaugeInVandaag";
            this.aGaugeVandaagRechts.Value = 0F;
            this.aGaugeVandaagRechts.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGaugeInVandaag_ValueInRangeChanged);
            // 
            // aGaugeVandaagLinks
            // 
            this.aGaugeVandaagLinks.BaseArcColor = System.Drawing.Color.Gray;
            this.aGaugeVandaagLinks.BaseArcRadius = 50;
            this.aGaugeVandaagLinks.BaseArcStart = 0;
            this.aGaugeVandaagLinks.BaseArcSweep = -90;
            this.aGaugeVandaagLinks.BaseArcWidth = 2;
            this.aGaugeVandaagLinks.Cap_Idx = ((byte)(1));
            this.aGaugeVandaagLinks.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGaugeVandaagLinks.CapPosition = new System.Drawing.Point(20, 75);
            this.aGaugeVandaagLinks.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(20, 75),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGaugeVandaagLinks.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGaugeVandaagLinks.CapText = "";
            this.aGaugeVandaagLinks.Center = new System.Drawing.Point(15, 80);
            this.aGaugeVandaagLinks.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGaugeVandaagLinks.Location = new System.Drawing.Point(338, 413);
            this.aGaugeVandaagLinks.MaxValue = 100F;
            this.aGaugeVandaagLinks.MinValue = 0F;
            this.aGaugeVandaagLinks.Name = "aGaugeVandaagLinks";
            this.aGaugeVandaagLinks.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGaugeVandaagLinks.NeedleColor2 = System.Drawing.Color.Black;
            this.aGaugeVandaagLinks.NeedleRadius = 50;
            this.aGaugeVandaagLinks.NeedleType = 0;
            this.aGaugeVandaagLinks.NeedleWidth = 2;
            this.aGaugeVandaagLinks.Range_Idx = ((byte)(0));
            this.aGaugeVandaagLinks.RangeColor = System.Drawing.Color.LightGreen;
            this.aGaugeVandaagLinks.RangeEnabled = false;
            this.aGaugeVandaagLinks.RangeEndValue = 300F;
            this.aGaugeVandaagLinks.RangeInnerRadius = 80;
            this.aGaugeVandaagLinks.RangeOuterRadius = 100;
            this.aGaugeVandaagLinks.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGaugeVandaagLinks.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGaugeVandaagLinks.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.aGaugeVandaagLinks.RangesInnerRadius = new int[] {
        80,
        10,
        80,
        80,
        80};
            this.aGaugeVandaagLinks.RangesOuterRadius = new int[] {
        100,
        50,
        100,
        100,
        100};
            this.aGaugeVandaagLinks.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.aGaugeVandaagLinks.RangeStartValue = -100F;
            this.aGaugeVandaagLinks.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGaugeVandaagLinks.ScaleLinesInterInnerRadius = 55;
            this.aGaugeVandaagLinks.ScaleLinesInterOuterRadius = 60;
            this.aGaugeVandaagLinks.ScaleLinesInterWidth = 2;
            this.aGaugeVandaagLinks.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGaugeVandaagLinks.ScaleLinesMajorInnerRadius = 50;
            this.aGaugeVandaagLinks.ScaleLinesMajorOuterRadius = 60;
            this.aGaugeVandaagLinks.ScaleLinesMajorStepValue = 50F;
            this.aGaugeVandaagLinks.ScaleLinesMajorWidth = 2;
            this.aGaugeVandaagLinks.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGaugeVandaagLinks.ScaleLinesMinorInnerRadius = 55;
            this.aGaugeVandaagLinks.ScaleLinesMinorNumOf = 9;
            this.aGaugeVandaagLinks.ScaleLinesMinorOuterRadius = 60;
            this.aGaugeVandaagLinks.ScaleLinesMinorWidth = 2;
            this.aGaugeVandaagLinks.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGaugeVandaagLinks.ScaleNumbersFormat = null;
            this.aGaugeVandaagLinks.ScaleNumbersRadius = 72;
            this.aGaugeVandaagLinks.ScaleNumbersRotation = 90;
            this.aGaugeVandaagLinks.ScaleNumbersStartScaleLine = 1;
            this.aGaugeVandaagLinks.ScaleNumbersStepScaleLines = 2;
            this.aGaugeVandaagLinks.Size = new System.Drawing.Size(117, 104);
            this.aGaugeVandaagLinks.TabIndex = 15;
            this.aGaugeVandaagLinks.Text = "aGaugeUitVandaag";
            this.aGaugeVandaagLinks.Value = 0F;
            this.aGaugeVandaagLinks.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGaugeUitVandaag_ValueInRangeChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVandaagRechts);
            this.Controls.Add(this.lblVandaagLinks);
            this.Controls.Add(this.lblWeekRechts);
            this.Controls.Add(this.lblWeekLinks);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.aGaugeTotaal);
            this.Controls.Add(this.aGaugeWeekRechts);
            this.Controls.Add(this.aGaugeWeekLinks);
            this.Controls.Add(this.aGaugeVandaagRechts);
            this.Controls.Add(this.aGaugeVandaagLinks);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(588, 578);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AGaugeApp.AGauge aGaugeVandaagRechts;
        private AGaugeApp.AGauge aGaugeVandaagLinks;
        private AGaugeApp.AGauge aGaugeWeekLinks;
        private AGaugeApp.AGauge aGaugeWeekRechts;
        private AGaugeApp.AGauge aGaugeTotaal;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblWeekLinks;
        private System.Windows.Forms.Label lblWeekRechts;
        private System.Windows.Forms.Label lblVandaagLinks;
        private System.Windows.Forms.Label lblVandaagRechts;

    }
}