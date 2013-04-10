using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace HelpdeskKPI
{
    public partial class frmDashboard : Form
    {
        private SqlConnection objConn;
        private const int intUpdateGridInterval = 10;
        private int intTicks;
        public frmDashboard()
        {
            intTicks = 0;
            InitializeComponent();
        }

        public enum ValueTypes
        {
            vtAangemeldOneDayToDate,
            vtAangemeldOneWeekToDate,
            vtAfgemeldOneDayToDate,
            vtAfgemeldOneWeekToDate,
            vtOpenstaandTotaal 
        }

        private void timReadValues_Tick(object sender, EventArgs e)
        {
            SqlCommand objCommandMonitor = new SqlCommand(@"
SELECT TYPE, AANTAL 
FROM v02_TopdeskMonitor 
WHERE TYPE in ('vtAangemeldOneDayToDate' ,'vtAangemeldOneWeekToDate' ,'vtAfgemeldOneDayToDate' ,'vtAfgemeldOneWeekToDate' ,'vtOpenstaandTotaal' )", objConn);
            SqlCommand objCommandTop10 = new SqlCommand(@"
SELECT TOP 10 KlantID, Klant, Aantal
FROM v03_TopdeskMonitorTop10
ORDER BY Aantal DESC
", objConn);
            try
            {
                objConn.Open();
                GetValues(objCommandMonitor);
                if((intTicks %intUpdateGridInterval)==0)
                {
                    GetTopTen(objCommandTop10);
                }
                intTicks++;
            }
            catch (Exception objException)
            {
                throw new Exception("Fout tijdens uitlezen gegegevens.", objException);
            }
            finally
            {
                if (objConn != null) objConn.Close();
            }
        }

        private void GetTopTen(SqlCommand command)
        {
            lstTopdeskMonitorTop10.Items.Clear();
            using (var objReader = command.ExecuteReader())
            {
                if (objReader != null)
                {
                    if(objReader.HasRows)
                    {
                        while(objReader.Read())
                        {
                            ListViewItem objItem = new ListViewItem(objReader["Klant"].ToString(),objReader["KlantID"].ToString());
                            objItem.SubItems.Add(objReader["Aantal"].ToString());
                            lstTopdeskMonitorTop10.Items.Add(objItem);
                        }
                    }
                }
            }
        }

        private void GetValues(SqlCommand command)
        {
            using (var objReader = command.ExecuteReader())
            {
                if (objReader != null)
                    if (objReader.HasRows)
                    {
                        while (objReader.Read())
                        {
                            ValueTypes enumValueType = (ValueTypes)Enum.Parse(typeof(ValueTypes), objReader["TYPE"].ToString());
                            switch (enumValueType)
                            {
                                case ValueTypes.vtAangemeldOneDayToDate:
                                    ucDashboard1.InVandaag = float.Parse(objReader["AANTAL"].ToString());
                                    break;
                                case ValueTypes.vtAfgemeldOneDayToDate:
                                    ucDashboard1.UitVandaag = float.Parse(objReader["AANTAL"].ToString());
                                    break;
                                case ValueTypes.vtAangemeldOneWeekToDate:
                                    ucDashboard1.InWeek = float.Parse(objReader["AANTAL"].ToString());
                                    break;
                                case ValueTypes.vtAfgemeldOneWeekToDate:
                                    ucDashboard1.UitWeek = float.Parse(objReader["AANTAL"].ToString());
                                    break;
                                case ValueTypes.vtOpenstaandTotaal:
                                    ucDashboard1.Totaal = float.Parse(objReader["AANTAL"].ToString());
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                        }
                    }
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            string strLogoLocation = ConfigurationManager.AppSettings["LogoLocation"] ?? Application.ExecutablePath;
            if(strLogoLocation[strLogoLocation.Length-1]!='\\')
            {
                strLogoLocation += '\\';
            }
            lstCustomers.Images.Clear();
            List<CustomerSectionHandler.Customer> colCustomers =
                (List<CustomerSectionHandler.Customer>)ConfigurationManager.GetSection("customers");
            foreach (CustomerSectionHandler.Customer objCustomer in colCustomers)
            {
                lstCustomers.Images.Add(objCustomer.ID, Image.FromFile(strLogoLocation + objCustomer.Image));
            }
            frmLogin objLogin = new frmLogin();
            if (objLogin.ShowDialog() == DialogResult.OK)
            {
                objConn = new SqlConnection(string.Format(ConfigurationManager.ConnectionStrings[objLogin.ConnectionName].ConnectionString, objLogin.Username, objLogin.Password));
                timReadValues.Start();
            }
            cbMeter1.SelectedIndex = 0;
            cbMeter2.SelectedIndex = 0;
            cbMeter3.SelectedIndex = 0;
            cbMeter4.SelectedIndex = 0;
            cbMeterTotaal.SelectedIndex = 0;
            objLogin.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucDashboard1_Load(object sender, EventArgs e)
        {

        }

    }
}
