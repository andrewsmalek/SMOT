﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace SMOTweb
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepeterBind();
        }
        protected void RepeterBind()
        {
            Event E = new Event();
            E.LoadAll();
            AllEventsRepeter.DataSource = E.DefaultView;
            AllEventsRepeter.DataBind();
        }
    }
}