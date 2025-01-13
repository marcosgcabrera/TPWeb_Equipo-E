<%@ Page Title="PROMO Gana!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromoTres.aspx.cs" Inherits="Web.PromoTres" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %></h2>
        <h5>Ingresa los datos para finalizar el proceso y participar!</h5>

        <div class="row">
            <div class="col-7">
                <div class="mb-3">
                    <label for="TboDocumento" class="form-label">Documento</label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TboDocumento" ValidationExpression="^\d+$" ForeColor="Red" ErrorMessage="Ingrese solo numeros" ValidationGroup="Group1" />
                    <asp:TextBox runat="server" ID="TboDocumento" CssClass="form-control" />
                    <label for="TboNombre" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" ID="TboNombre" CssClass="form-control" />
                    <label for="TboApellido" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" ID="TboApellido" CssClass="form-control" />
                    <label for="txtEmail" class="form-label">Email address</label>
                    <asp:TextBox runat ="server" ID="txtEmail" TextMode="Email" CssClass="form-control" placeholder="tuemail@ejemplo.com" />
                    <label for="TboDireccion" class="form-label">Direccion</label>
                    <asp:TextBox runat="server" ID="TboDireccion" CssClass="form-control" />
                    <label for="TboCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="TboCiudad" CssClass="form-control" />
                    <label for="TboCp" class="form-label">Codigo Postal</label>
                    <asp:TextBox runat="server" ID="TboCp" CssClass="form-control" />
                    <asp:RegularExpressionValidator ID="RegexValidator" runat="server" ControlToValidate="TboCp" ValidationExpression="^\d+$" ForeColor="Red" ErrorMessage="Ingrese solo numeros" ValidationGroup="Group1" />
                </div>
            </div>
        </div>


        <asp:Label ID="LabelEnviar" runat="server" ></asp:Label>
        <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" ValidationGroup="Group1" OnClick="BtnEnviar_Click" />
        <a href="Default.aspx"></a>

    </main>
</asp:Content>
