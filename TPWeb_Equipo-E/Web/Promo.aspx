<%@ Page Title="PROMO Gana!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Promo.aspx.cs" Inherits="Web.Promo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <h3>Bienvenido! Aca podes canjear tu voucher para ganar PREMIOS!</h3>
        <p>Sigue las instrucciones para arrancar a participar!</p>


        <asp:Label ID="LabelTboVoucher" runat="server" Text="Ingresa Tu Codigo de Voucher"></asp:Label>
        <asp:TextBox ID="TextBoxVoucher" placeholder="XXXXXXXXXXXXXXXX" runat="server"></asp:TextBox>



    </main>
</asp:Content>
