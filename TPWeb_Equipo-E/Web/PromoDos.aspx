<%@ Page Title="PROMO Gana!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromoDos.aspx.cs" Inherits="Web.PromoDos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<main aria-labelledby="title">
        <h2> Elegi tu Premio! </h2>
    <div>
    <img src="..." class="img-thumbnail" alt="...">
        <div>
            
        <asp:Button Text="Premio 1" CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server"/>
            </div>
    </div>
     <div>
  <img src="..." class="img-thumbnail" alt="...">
     <div>
     <asp:Button Text="Premio 2" CssClass="btn btn-primary" ID="Button1" OnClick="Button1_Click" runat="server"/>
         </div>
 </!--div>
     <div>
 <img src="..." class="img-thumbnail" alt="...">
     <div>
     <asp:Button Text="Premio 3" CssClass="btn btn-primary" ID="Button2" OnClick="Button2_Click" runat="server"/>
         </div>
 </div>




    </main>

</asp:Content>