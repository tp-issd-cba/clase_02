﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace clase_02 {
    public partial class WebForm2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            StreamWriter arch = new StreamWriter(Server.MapPath(".") +
"/visitas.txt", true);
            arch.WriteLine("Nombre:" + TextBox1.Text);
            arch.WriteLine("<br>");
            arch.WriteLine("Pais:" + TextBox2.Text);
            arch.WriteLine("<br>");
            arch.WriteLine("Comentarios<br>");
            arch.WriteLine(TextBox3.Text);
            arch.WriteLine("<br>");
            arch.WriteLine("<hr>");
            arch.Close();
            FormResultLabel.Text = "Datos Registrados";
        }
    }
}