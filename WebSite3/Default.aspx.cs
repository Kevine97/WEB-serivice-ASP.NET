using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : Page
{
    ServiceReference1.Tipo_Cambio_BCNSoapClient WS = new ServiceReference1.Tipo_Cambio_BCNSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        //txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtFecha.Text.Length > 0 && (rdbDIA.Checked == true || rdbMES.Checked == true))
        {
            DateTime dia_Actual = Convert.ToDateTime(txtFecha.Text);
            String ano = Convert.ToString(dia_Actual.Year);
            String mes = Convert.ToString(dia_Actual.Month);
            String dia = Convert.ToString(dia_Actual.Day);

            if (rdbDIA.Checked == true)
            {
                Label1.Text = "Tipo de cambio en Córdobas por USD:" + "\t\t" + WS.RecuperaTC_Dia(Convert.ToInt32(ano), Convert.ToInt32(mes), Convert.ToInt32(dia)).ToString();
                switch (mes)
                {
                    case "1": Label2.Text = "Fecha: " + dia + " de enero del " + ano; break;
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

                grdtc.DataSource = "";
                grdtc.DataBind();

            }
            else if (rdbMES.Checked == true)
            {
                Label1.Text = "";
                Label2.Text = "";
                try
                {
                    XmlDocument doc = new XmlDocument();
                    XmlNodeList nodeList;
                    //Consumimos el servicio
                    doc.LoadXml(WS.RecuperaTC_Mes(Convert.ToInt32(ano), Convert.ToInt32(mes)).ToString());
                    nodeList = doc.GetElementsByTagName("Tc");

                    DataTable dt = new DataTable();

                    // AGREGAMOS LAS COLUMNAS AL DATATABLE 
                    foreach (XmlNode Node in nodeList.Item(0).ChildNodes)
                    {
                        DataColumn Col = new DataColumn(Node.Name, System.Type.GetType("System.String"));

                        dt.Columns.Add(Col);

                    }


                    //AGREGAR LA INFORMACION AL DATATABLE 
                    for (int i = 0; i < nodeList.Count - 1; i++)
                    {
                        DataRow dr = dt.NewRow();

                        for (int Col = 0; Col < dt.Columns.Count; Col++)
                        {
                            if (!DBNull.Value.Equals(nodeList.Item(i).ChildNodes[Col].InnerText))
                                dr[Col] = nodeList.Item(i).ChildNodes[Col].InnerText;
                            else
                                dr[Col] = null;
                        }
                        dt.Rows.Add(dr);
                    }

                    grdtc.DataSource = dt;
                    grdtc.DataBind();
                }
                catch (NullReferenceException ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), Label1.Text = ex.ToString(), true.ToString());

                }
            }
        }
        else
        {
            Label1.Text = "Favor ingrese una fecha";
            Label2.Text = "";
        }




    }



   
}

