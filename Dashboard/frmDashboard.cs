using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Xml.Serialization;

using SpPerfChart;

namespace HelpdeskKPI
{
    public partial class frmDashboard : Form
    {
        private SqlConnection objConn;
        private const int intUpdateGridInterval = 10;
        private const int intUpdatePerfChartInterval = 3600;
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
            vtOpenstaandTotaal,
            vtOpenstaandProjectTotaal
        }

        private void timReadValues_Tick(object sender, EventArgs e)
        {
            SqlCommand objCommandMonitor;
            SqlCommand objCommandTop10;
            if (cbMeterTotaal.SelectedItem.ToString() == "Production Open")
            {
                objCommandMonitor =
                    new SqlCommand(
                        @"SELECT  'vtOpenstaandProjectTotaal' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND incident.afgemeld = 0
UNION
SELECT TYPE, AANTAL 
FROM v02_TopdeskMonitor 
WHERE TYPE in ('vtAangemeldOneDayToDate' ,'vtAangemeldOneWeekToDate' ,'vtAfgemeldOneDayToDate' ,'vtAfgemeldOneWeekToDate' ,'vtOpenstaandTotaal' )",
                        objConn);
                objCommandTop10 = new SqlCommand(@"
                SELECT TOP 10 KlantID, Klant, Aantal
                FROM v03_TopdeskMonitorTop10
                ORDER BY Aantal DESC
                ", objConn);
            }
            else
            {
                objCommandMonitor = new SqlCommand(@"
SELECT  'vtAangemeldOneDayToDate' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND datumaangemeld BETWEEN GETDATE()-1 AND GETDATE()
UNION
SELECT  'vtAangemeldOneWeekToDate' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND datumaangemeld BETWEEN GETDATE()-7 AND GETDATE()
UNION
SELECT  'vtAfgemeldOneDayToDate' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND datumafgemeld BETWEEN GETDATE()-1 AND GETDATE()
UNION
SELECT  'vtAfgemeldOneWeekToDate' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND datumafgemeld BETWEEN GETDATE()-7 AND GETDATE()
UNION
SELECT  'vtOpenstaandProjectTotaal' AS TYPE, COUNT(0) AS AANTAL
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
        AND incident.afgemeld = 0
UNION
SELECT TYPE, AANTAL 
FROM v02_TopdeskMonitor 
WHERE TYPE in ('vtOpenstaandTotaal' )", objConn);
                objCommandTop10 = new SqlCommand(@"
SELECT TOP 10
        aanmeldervestiging AS Klant,
        aanmeldervestigingid AS KlantID,
        COUNT(0) AS Aantal
FROM    dbo.incident
        INNER JOIN soortmelding ON dbo.incident.soortmeldingid = dbo.soortmelding.unid
WHERE   incident.afgemeld = 0
        AND soortmelding.naam LIKE 'Project%'
        AND aanmeldervestigingid <> '7v0001'
GROUP BY aanmeldervestiging ,
        aanmeldervestigingid
ORDER BY COUNT(0) DESC", objConn); 
            }
            
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
                                    if (cbMeterTotaal.SelectedItem.ToString() == "Production Open")
                                    {
                                        ucDashboard1.Totaal = float.Parse(objReader["AANTAL"].ToString());
                                        perfChart1.Visible = true;
                                        perfChart2.Visible = false;
                                    }
                                    
                                    if ((intTicks % intUpdatePerfChartInterval) == 0)
                                    {
                                        //TODO: Check last login time and interpolate with values according to chart interval.
                                        perfChart1.AddValue(decimal.Parse(objReader["AANTAL"].ToString()));
                                    }
                                    break;
                                case ValueTypes.vtOpenstaandProjectTotaal:
                                    if (cbMeterTotaal.SelectedItem.ToString() == "Project Open")
                                    {
                                        ucDashboard1.Totaal = float.Parse(objReader["AANTAL"].ToString());
                                        perfChart1.Visible = false;
                                        perfChart2.Visible = true;
                                    }
                                    if ((intTicks % intUpdatePerfChartInterval) == 0)
                                    {
                                        //TODO: Check last login time and interpolate with values according to chart interval.

                                        perfChart2.AddValue(decimal.Parse(objReader["AANTAL"].ToString()));
                                    }
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
                if (File.Exists(strLogoLocation + objCustomer.Image))
                {
                    lstCustomers.Images.Add(objCustomer.ID, Image.FromFile(strLogoLocation + objCustomer.Image));
                }
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
            //
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            //perfChart1.AddValue(randGen.Next(200));
            XmlSerializer serializer = new XmlSerializer(typeof(PerfChartMemento));
            perfChart1.ScaleMode = SpPerfChart.ScaleMode.Relative;
            perfChart1.TimerMode = SpPerfChart.TimerMode.Disabled;
            perfChart2.ScaleMode = SpPerfChart.ScaleMode.Relative;
            perfChart2.TimerMode = SpPerfChart.TimerMode.Disabled;
            var settingsFileTotal = new FileInfo(Path.Combine(Application.LocalUserAppDataPath, "SettingsTotal.xml"));
            if (settingsFileTotal.Exists)
            {
                using (var reader = settingsFileTotal.OpenText())
                {
                    var savedState = serializer.Deserialize(reader);
                    perfChart1.Restore_state(savedState);
                }
            }
            else
            {
                Random randGen = new Random();
                for (int i = 0; i < 725; i++)
                {
                    perfChart1.AddValue(randGen.Next(280));
                }
            }
            var settingsFileProject = new FileInfo(Path.Combine(Application.LocalUserAppDataPath, "SettingsProject.xml"));
            if (settingsFileProject.Exists)
            {
                using (var reader = settingsFileProject.OpenText())
                {
                    var savedState = serializer.Deserialize(reader);
                    perfChart2.Restore_state(savedState);
                }
            }
            else
            {
                Random randGen = new Random();
                for (int i = 0; i < 725; i++)
                {
                    perfChart2.AddValue(randGen.Next(280));
                }
            }
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

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var savedStateTotal = perfChart1.Get_current_state();
            XmlSerializer serializer = new XmlSerializer(savedStateTotal.GetType());
            var settingsFileTotal =  new FileInfo(Path.Combine(Application.LocalUserAppDataPath,"SettingsTotal.xml"));
            using (var writer = settingsFileTotal.CreateText())
            {
                serializer.Serialize(writer, savedStateTotal);
                writer.Close();
            }
            var savedStateProject = perfChart2.Get_current_state();
            serializer = new XmlSerializer(savedStateProject.GetType());
            var settingsFile = new FileInfo(Path.Combine(Application.LocalUserAppDataPath, "SettingsProject.xml"));
            using (var writer = settingsFile.CreateText())
            {
                serializer.Serialize(writer, savedStateProject);
                writer.Close();
            }
        }


    }
}
