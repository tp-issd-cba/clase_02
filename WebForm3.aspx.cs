﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_02 {
    public partial class WebForm3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            StreamReader arch = new StreamReader($"{Server.MapPath(".")}/visitas.txt");
            Label1.Text = arch.ReadToEnd();
            arch.Close();
        }
    }
}