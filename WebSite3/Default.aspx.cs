using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    ServiceReference1.Tipo_Cambio_BCNSoapClient WS = new ServiceReference1.Tipo_Cambio_BCNSoapClient();
 
    protected void Page_Load(object sender, EventArgs e)
    {
        //txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtFecha.Text.Length > 0)
       {
            DateTime dia_Actual = Convert.ToDateTime(txtFecha.Text);
            String ano = Convert.ToString(dia_Actual.Year);
            String mes = Convert.ToString(dia_Actual.Month);
            String dia = Convert.ToString(dia_Actual.Day);

        Label1.Text = "Tipo de cambio en Córdobas por USD:" + "\t\t"+ WS.RecuperaTC_Dia(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia)).ToString();
           switch (mes)
           {
               case "1":Label2.Text = "Fecha: "+dia+" de enero del "+ano; break;
               case "2": Label2.Text = "Fecha: " + dia + " de febrero del " + ano; break;
               case "3": Label2.Text = "Fecha: " + dia + " de marzo del " + ano; break;
               case "4": Label2.Text = "Fecha: " + dia + " de abril del " + ano; break;
               case "5": Label2.Text = "Fecha: " + dia + " de mayo del " + ano; break;
               case "6": Label2.Text = "Fecha: " + dia + " de junio del " + ano; break;
               case "7": Label2.Text = "Fecha: " + dia + " de julio del " + ano; break;
               case "8": Label2.Text = "Fecha: " + dia + " de agosto del " + ano; break;
               case "9": Label2.Text = "Fecha: " + dia + " de septiembre del " + ano; break;
               case "10": Label2.Text = "Fecha: " + dia + " de ooctubre del " + ano; break;
               case "11": Label2.Text = "Fecha: " + dia + " de noviembre del " + ano; break;
               case "12": Label2.Text = "Fecha: " + dia + " de diciembre del " + ano; break;
           }
       }
       else
       {
           Label1.Text = "Favor ingrese una fecha";
           Label2.Text = "";
       }




    }
}
