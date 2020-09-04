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
        <p ><asp:TextBox ID="txtFecha" runat="server" Width="1229px" TextMode="Date" class="form-control"></asp:TextBox></p>
        <p><asp:Button ID="Button1" runat="server"  Text="Consumir AHORA" class="btn btn-danger btn-lg" Width="1241px" OnClick="Button1_Click" /></p>
        
        <p class="text-center"> <asp:Label ID="Label1" class="label text-center" runat="server" Text="" ></asp:Label> 
       <asp:Label ID="Label2" class="label text-center" runat="server" Text="" ></asp:Label></p>
       
    </div>
        </div>
    </div>

    
</asp:Content>
