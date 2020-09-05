<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1 class="text-center titulo">Servicio W E B</h1><hr />
    <div class="row text_center">
           <div class="col-lg-6">
            <img src="../img/imagen23.png" class="img-fluid">
            </div>

    <div class="col-lg-4">
    <div class="jumbotron ">
        <h3 class="lead ke">Tipo de Cambio</h3><hr />
        <p class="lead text-center">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript</p>
        <p><asp:RadioButton ID="rdbDIA" runat="server" ForeColor="#1F1E46" GroupName="cambio" Text=" Tipo de cambio dia" Font-Size="Medium" />
            <br />
            <asp:RadioButton ID="rdbMES" runat="server" ForeColor="#1F1E46" GroupName="cambio" Text="Tipo de cambio mes" Font-Size="Medium" /></p>
        <p ><asp:TextBox ID="txtFecha" runat="server" Width="1229px" TextMode="Date" class="form-control"></asp:TextBox></p>
        <p><asp:Button ID="Button1" runat="server"  Text="Consumir AHORA" class="btn btn-danger btn-lg" Width="1241px" OnClick="Button1_Click" /></p>
        
        <p class="text-center"> <asp:Label ID="Label1" class="label text-center" runat="server" Text="" ></asp:Label> 
       <asp:Label ID="Label2" class="label text-center" runat="server" Text="" ></asp:Label></p>
       
    </div>
         <table class="table" id="tabla">
             <thead class="thead-dark">
                <tr>
                    <td class="style2" colspan="2">
                        <asp:GridView ID="grdtc" CssClass="table table-condensed" runat="server" Width="331px">


                        </asp:GridView>
                    </td>
                </tr>
               </thead>
            </table>
        </div>
    </div>

    
</asp:Content>
