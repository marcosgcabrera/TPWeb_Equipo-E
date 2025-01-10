<%@ Page Title="PROMO Gana!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Promo.aspx.cs" Inherits="Web.Promo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <h3>Bienvenido! Aca podes canjear tu voucher para ganar PREMIOS!</h3>
        <p>Sigue las instrucciones para arrancar a participar!</p>


        <asp:Label ID="LabelVoucher" runat="server" Text="Ingresa Tu Codigo de Voucher"></asp:Label>
        <asp:TextBox ID="TBoVoucher" placeholder="XXXXXXXXXXXXXXXX" runat="server"></asp:TextBox>
        <asp:Button ID="BtnSiguiente" runat="server" Text="Siguiente" OnClick="BtnSiguiente_Click" />
        <asp:Label ID="ErrorMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>


        <a href="PromoDos"></a>

    </main>
</asp:Content>
