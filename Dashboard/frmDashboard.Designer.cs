using System.Configuration;

namespace HelpdeskKPI
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            SpPerfChart.ChartPen chartPen1 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen2 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen3 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen4 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen5 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen6 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen7 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen8 = new SpPerfChart.ChartPen();
            this.timReadValues = new System.Windows.Forms.Timer(this.components);
            this.picTopDesk = new System.Windows.Forms.PictureBox();
            this.picTensing = new System.Windows.Forms.PictureBox();
            this.lstTopdeskMonitorTop10 = new System.Windows.Forms.ListView();
            this.colKlant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstCustomers = new System.Windows.Forms.ImageList(this.components);
            this.cbMeter1 = new System.Windows.Forms.ComboBox();
            this.cbMeter2 = new System.Windows.Forms.ComboBox();
            this.cbMeter3 = new System.Windows.Forms.ComboBox();
            this.cbMeter4 = new System.Windows.Forms.ComboBox();
            this.cbMeterTotaal = new System.Windows.Forms.ComboBox();
            this.perfChart2 = new SpPerfChart.PerfChart();
            this.perfChart1 = new SpPerfChart.PerfChart();
            this.ucDashboard1 = new AGaugeApp.Dashboard();
            ((System.ComponentModel.ISupportInitialize)(this.picTopDesk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTensing)).BeginInit();
            this.SuspendLayout();
            // 
            // timReadValues
            // 
            this.timReadValues.Interval = 1000;
            this.timReadValues.Tick += new System.EventHandler(this.timReadValues_Tick);
            // 
            // picTopDesk
            // 
            this.picTopDesk.Image = global::HelpdeskKPI.Properties.Resources.logo;
            this.picTopDesk.Location = new System.Drawing.Point(573, 12);
            this.picTopDesk.Name = "picTopDesk";
            this.picTopDesk.Size = new System.Drawing.Size(164, 37);
            this.picTopDesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTopDesk.TabIndex = 2;
            this.picTopDesk.TabStop = false;
            // 
            // picTensing
            // 
            this.picTensing.Image = global::HelpdeskKPI.Properties.Resources.tensing1;
            this.picTensing.Location = new System.Drawing.Point(12, 12);
            this.picTensing.Name = "picTensing";
            this.picTensing.Size = new System.Drawing.Size(164, 166);
            this.picTensing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTensing.TabIndex = 1;
            this.picTensing.TabStop = false;
            // 
            // lstTopdeskMonitorTop10
            // 
            this.lstTopdeskMonitorTop10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTopdeskMonitorTop10.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKlant,
            this.colAantal});
            this.lstTopdeskMonitorTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lstTopdeskMonitorTop10.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstTopdeskMonitorTop10.Location = new System.Drawing.Point(749, 12);
            this.lstTopdeskMonitorTop10.Name = "lstTopdeskMonitorTop10";
            this.lstTopdeskMonitorTop10.Size = new System.Drawing.Size(253, 708);
            this.lstTopdeskMonitorTop10.SmallImageList = this.lstCustomers;
            this.lstTopdeskMonitorTop10.TabIndex = 9;
            this.lstTopdeskMonitorTop10.UseCompatibleStateImageBehavior = false;
            this.lstTopdeskMonitorTop10.View = System.Windows.Forms.View.Details;
            // 
            // colKlant
            // 
            this.colKlant.Text = "Klant";
            this.colKlant.Width = 194;
            // 
            // colAantal
            // 
            this.colAantal.Text = "Aantal";
            this.colAantal.Width = 55;
            // 
            // lstCustomers
            // 
            this.lstCustomers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstCustomers.ImageStream")));
            this.lstCustomers.TransparentColor = System.Drawing.Color.Transparent;
            this.lstCustomers.Images.SetKeyName(0, "Gh0001");
            this.lstCustomers.Images.SetKeyName(1, "5H000U");
            this.lstCustomers.Images.SetKeyName(2, "Bx0001");
            this.lstCustomers.Images.SetKeyName(3, "5H001Q");
            this.lstCustomers.Images.SetKeyName(4, "5c0003");
            this.lstCustomers.Images.SetKeyName(5, "5H000P");
            this.lstCustomers.Images.SetKeyName(6, "5H000g");
            this.lstCustomers.Images.SetKeyName(7, "5H0012");
            this.lstCustomers.Images.SetKeyName(8, "5H000X");
            this.lstCustomers.Images.SetKeyName(9, "5H001K");
            this.lstCustomers.Images.SetKeyName(10, "5H000R");
            this.lstCustomers.Images.SetKeyName(11, "690002");
            this.lstCustomers.Images.SetKeyName(12, "5H000d");
            this.lstCustomers.Images.SetKeyName(13, "5H000O");
            this.lstCustomers.Images.SetKeyName(14, "6F0001");
            this.lstCustomers.Images.SetKeyName(15, "5H000L");
            this.lstCustomers.Images.SetKeyName(16, "5H000c");
            this.lstCustomers.Images.SetKeyName(17, "5H000T");
            this.lstCustomers.Images.SetKeyName(18, "5O0001");
            this.lstCustomers.Images.SetKeyName(19, "5c0001");
            this.lstCustomers.Images.SetKeyName(20, "Cm0002");
            this.lstCustomers.Images.SetKeyName(21, "5H0007");
            this.lstCustomers.Images.SetKeyName(22, "5H001f");
            this.lstCustomers.Images.SetKeyName(23, "7y0001");
            this.lstCustomers.Images.SetKeyName(24, "5H000l");
            this.lstCustomers.Images.SetKeyName(25, "5H0016");
            this.lstCustomers.Images.SetKeyName(26, "AO0001");
            this.lstCustomers.Images.SetKeyName(27, "b00001");
            this.lstCustomers.Images.SetKeyName(28, "5H000B");
            this.lstCustomers.Images.SetKeyName(29, "5H000m");
            this.lstCustomers.Images.SetKeyName(30, "5H000f");
            this.lstCustomers.Images.SetKeyName(31, "5H000E");
            this.lstCustomers.Images.SetKeyName(32, "5H000J");
            this.lstCustomers.Images.SetKeyName(33, "TB0001");
            this.lstCustomers.Images.SetKeyName(34, "71000V");
            this.lstCustomers.Images.SetKeyName(35, "5H000A");
            this.lstCustomers.Images.SetKeyName(36, "5H001S");
            this.lstCustomers.Images.SetKeyName(37, "5H000v");
            this.lstCustomers.Images.SetKeyName(38, "vf0001");
            this.lstCustomers.Images.SetKeyName(39, "5H000W");
            this.lstCustomers.Images.SetKeyName(40, "3g0001");
            this.lstCustomers.Images.SetKeyName(41, "4w0001");
            this.lstCustomers.Images.SetKeyName(42, "5H001c");
            this.lstCustomers.Images.SetKeyName(43, "5H000V");
            this.lstCustomers.Images.SetKeyName(44, "NC0001");
            this.lstCustomers.Images.SetKeyName(45, "Ej0001");
            this.lstCustomers.Images.SetKeyName(46, "5H0019");
            this.lstCustomers.Images.SetKeyName(47, "5H001U");
            this.lstCustomers.Images.SetKeyName(48, "5H001b");
            this.lstCustomers.Images.SetKeyName(49, "5H001C");
            this.lstCustomers.Images.SetKeyName(50, "5H001g");
            this.lstCustomers.Images.SetKeyName(51, "5H000S");
            this.lstCustomers.Images.SetKeyName(52, "5H001P");
            this.lstCustomers.Images.SetKeyName(53, "5H001i");
            this.lstCustomers.Images.SetKeyName(54, "5H000Q");
            this.lstCustomers.Images.SetKeyName(55, "5H0013");
            this.lstCustomers.Images.SetKeyName(56, "PW0002");
            this.lstCustomers.Images.SetKeyName(57, "5H000C");
            this.lstCustomers.Images.SetKeyName(58, "5H001A");
            this.lstCustomers.Images.SetKeyName(59, "5H000Z");
            this.lstCustomers.Images.SetKeyName(60, "5H000Y");
            this.lstCustomers.Images.SetKeyName(61, "5H001D");
            this.lstCustomers.Images.SetKeyName(62, "5H001N");
            this.lstCustomers.Images.SetKeyName(63, "5H001Y");
            this.lstCustomers.Images.SetKeyName(64, "Cm0001");
            this.lstCustomers.Images.SetKeyName(65, "lo0001");
            // 
            // cbMeter1
            // 
            this.cbMeter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMeter1.FormattingEnabled = true;
            this.cbMeter1.Items.AddRange(new object[] {
            "Aangemeld/week"});
            this.cbMeter1.Location = new System.Drawing.Point(86, 393);
            this.cbMeter1.Name = "cbMeter1";
            this.cbMeter1.Size = new System.Drawing.Size(118, 21);
            this.cbMeter1.TabIndex = 10;
            // 
            // cbMeter2
            // 
            this.cbMeter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMeter2.FormattingEnabled = true;
            this.cbMeter2.Items.AddRange(new object[] {
            "Afgemeld/week"});
            this.cbMeter2.Location = new System.Drawing.Point(209, 393);
            this.cbMeter2.Name = "cbMeter2";
            this.cbMeter2.Size = new System.Drawing.Size(118, 21);
            this.cbMeter2.TabIndex = 11;
            // 
            // cbMeter3
            // 
            this.cbMeter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMeter3.FormattingEnabled = true;
            this.cbMeter3.Items.AddRange(new object[] {
            "Aangemeld/24u"});
            this.cbMeter3.Location = new System.Drawing.Point(414, 393);
            this.cbMeter3.Name = "cbMeter3";
            this.cbMeter3.Size = new System.Drawing.Size(118, 21);
            this.cbMeter3.TabIndex = 12;
            this.cbMeter3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbMeter4
            // 
            this.cbMeter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMeter4.FormattingEnabled = true;
            this.cbMeter4.Items.AddRange(new object[] {
            "Afgemeld/24u"});
            this.cbMeter4.Location = new System.Drawing.Point(537, 393);
            this.cbMeter4.Name = "cbMeter4";
            this.cbMeter4.Size = new System.Drawing.Size(118, 21);
            this.cbMeter4.TabIndex = 13;
            this.cbMeter4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cbMeterTotaal
            // 
            this.cbMeterTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMeterTotaal.FormattingEnabled = true;
            this.cbMeterTotaal.Items.AddRange(new object[] {
            "Production Open",
            "Project Open"});
            this.cbMeterTotaal.Location = new System.Drawing.Point(294, 12);
            this.cbMeterTotaal.Name = "cbMeterTotaal";
            this.cbMeterTotaal.Size = new System.Drawing.Size(164, 21);
            this.cbMeterTotaal.TabIndex = 14;
            // 
            // perfChart2
            // 
            this.perfChart2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.perfChart2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.perfChart2.Location = new System.Drawing.Point(12, 620);
            this.perfChart2.Name = "perfChart2";
            this.perfChart2.PerfChartStyle.AntiAliasing = true;
            chartPen1.Color = System.Drawing.Color.Yellow;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen1.Width = 1F;
            this.perfChart2.PerfChartStyle.AvgLinePen = chartPen1;
            this.perfChart2.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.DeepSkyBlue;
            this.perfChart2.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.LightSkyBlue;
            chartPen2.Color = System.Drawing.Color.DarkOrange;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 1F;
            this.perfChart2.PerfChartStyle.ChartLinePen = chartPen2;
            chartPen3.Color = System.Drawing.Color.PaleGoldenrod;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen3.Width = 1F;
            this.perfChart2.PerfChartStyle.HorizontalGridPen = chartPen3;
            this.perfChart2.PerfChartStyle.ShowAverageLine = true;
            this.perfChart2.PerfChartStyle.ShowHorizontalGridLines = true;
            this.perfChart2.PerfChartStyle.ShowVerticalGridLines = true;
            chartPen4.Color = System.Drawing.Color.PaleGoldenrod;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen4.Width = 1F;
            this.perfChart2.PerfChartStyle.VerticalGridPen = chartPen4;
            this.perfChart2.ScaleMode = SpPerfChart.ScaleMode.Relative;
            this.perfChart2.Size = new System.Drawing.Size(725, 100);
            this.perfChart2.TabIndex = 16;
            this.perfChart2.TimerInterval = 100;
            this.perfChart2.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage;
            // 
            // perfChart1
            // 
            this.perfChart1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.perfChart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.perfChart1.Location = new System.Drawing.Point(12, 620);
            this.perfChart1.Name = "perfChart1";
            this.perfChart1.PerfChartStyle.AntiAliasing = true;
            chartPen5.Color = System.Drawing.Color.LightGreen;
            chartPen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            chartPen5.Width = 1F;
            this.perfChart1.PerfChartStyle.AvgLinePen = chartPen5;
            this.perfChart1.PerfChartStyle.BackgroundColorBottom = System.Drawing.Color.DarkOliveGreen;
            this.perfChart1.PerfChartStyle.BackgroundColorTop = System.Drawing.Color.YellowGreen;
            chartPen6.Color = System.Drawing.Color.Red;
            chartPen6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen6.Width = 1F;
            this.perfChart1.PerfChartStyle.ChartLinePen = chartPen6;
            chartPen7.Color = System.Drawing.Color.DarkOliveGreen;
            chartPen7.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen7.Width = 1F;
            this.perfChart1.PerfChartStyle.HorizontalGridPen = chartPen7;
            this.perfChart1.PerfChartStyle.ShowAverageLine = true;
            this.perfChart1.PerfChartStyle.ShowHorizontalGridLines = true;
            this.perfChart1.PerfChartStyle.ShowVerticalGridLines = true;
            chartPen8.Color = System.Drawing.Color.DarkOliveGreen;
            chartPen8.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chartPen8.Width = 1F;
            this.perfChart1.PerfChartStyle.VerticalGridPen = chartPen8;
            this.perfChart1.ScaleMode = SpPerfChart.ScaleMode.Relative;
            this.perfChart1.Size = new System.Drawing.Size(725, 100);
            this.perfChart1.TabIndex = 15;
            this.perfChart1.TimerInterval = 100;
            this.perfChart1.TimerMode = SpPerfChart.TimerMode.SynchronizedAverage;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.InVandaag = 0F;
            this.ucDashboard1.InWeek = 0F;
            this.ucDashboard1.Location = new System.Drawing.Point(86, 12);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(601, 602);
            this.ucDashboard1.TabIndex = 0;
            this.ucDashboard1.Totaal = 0F;
            this.ucDashboard1.UitVandaag = 0F;
            this.ucDashboard1.UitWeek = 0F;
            this.ucDashboard1.Load += new System.EventHandler(this.ucDashboard1_Load);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 732);
            this.Controls.Add(this.perfChart2);
            this.Controls.Add(this.perfChart1);
            this.Controls.Add(this.cbMeterTotaal);
            this.Controls.Add(this.cbMeter4);
            this.Controls.Add(this.cbMeter3);
            this.Controls.Add(this.cbMeter2);
            this.Controls.Add(this.cbMeter1);
            this.Controls.Add(this.lstTopdeskMonitorTop10);
            this.Controls.Add(this.picTopDesk);
            this.Controls.Add(this.picTensing);
            this.Controls.Add(this.ucDashboard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTopDesk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTensing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timReadValues;
        private AGaugeApp.Dashboard ucDashboard;
        private AGaugeApp.Dashboard ucDashboard1;
        private System.Windows.Forms.PictureBox picTensing;
        private System.Windows.Forms.PictureBox picTopDesk;
        private System.Windows.Forms.ListView lstTopdeskMonitorTop10;
        private System.Windows.Forms.ColumnHeader colKlant;
        private System.Windows.Forms.ColumnHeader colAantal;
        private System.Windows.Forms.ImageList lstCustomers;
        private System.Windows.Forms.ComboBox cbMeter1;
        private System.Windows.Forms.ComboBox cbMeter2;
        private System.Windows.Forms.ComboBox cbMeter3;
        private System.Windows.Forms.ComboBox cbMeter4;
        private System.Windows.Forms.ComboBox cbMeterTotaal;
        private SpPerfChart.PerfChart perfChart1;
        private SpPerfChart.PerfChart perfChart2;


    }
}

