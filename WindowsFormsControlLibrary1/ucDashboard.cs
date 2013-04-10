using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HelpdeskKPIControl
{
    [ComVisible(true)]
    public partial class ucDashboard : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        public string InVandaag
        {
            get
            {
                return lblInVandaag.Text;
            }
            set
            {
                lblInVandaag.Text = value;
            }
        }
        public string UitVandaag
        {
            get
            {
                return lblUitVandaag.Text;
            }
            set
            {
                lblUitVandaag.Text = value;
            }
        }
        public string InWeek
        {
            get
            {
                return lblInWeek.Text;
            }
            set
            {
                lblInWeek.Text = value;
            }
        }
        public string UitWeek
        {
            get
            {
                return lblUitWeek.Text;
            }
            set
            {
                lblUitWeek.Text = value;
            }
        }
        public string InMaand
        {
            get
            {
                return lblInMaand.Text;
            }
            set
            {
                lblInMaand.Text = value;
            }
        }
        public string UitMaand
        {
            get
            {
                return lblUitMaand.Text;
            }
            set
            {
                lblUitMaand.Text = value;
            }
        }
    }
}
