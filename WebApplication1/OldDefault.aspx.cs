using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (objInVandaag != null) objInVandaag.Attributes["VALUE"] = "0";
            if (objInVandaag != null) objUitVandaag.Attributes["VALUE"] = "0";
            if (objInVandaag != null) objInWeek.Attributes["VALUE"] = "0";
            if (objInVandaag != null) objUitWeek.Attributes["VALUE"] = "0";
            if (objInVandaag != null) objInMaand.Attributes["VALUE"] = "0";
            if (objInVandaag != null) objUitMaand.Attributes["VALUE"] = "0";
            
        }
    }
}
