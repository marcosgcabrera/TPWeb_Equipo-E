<%@ Page Title="PROMO Gana!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromoDos.aspx.cs" Inherits="Web.PromoDos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<main aria-labelledby="title">
        <h2> Elegi tu Premio! </h2>
   
    
 <div class="row row-cols-1 row-cols-md-3 g-4">

 <asp:Repeater runat="server" ID="repRepetidor">
 <ItemTemplate>
<div class="col">
    <div class="card">
      
      <div class="card-body">
        <h5 class="card-title"><%#Eval("Nombre") %></h5>
        <p class="card-text"><%#Eval("Descripcion") %></p>
          
          <asp:button text="Seleccionar" CssClass="btn btn-primary" runat="server" id="btnSeleccionar" CommandArgument='<%#Eval("Id") %>' CommandName="ArticuloId" OnClick="btnSeleccionar_Click" />
      </div>
    </div>
</div>
</ItemTemplate>
        </asp:Repeater>


    </main>

</asp:Content>