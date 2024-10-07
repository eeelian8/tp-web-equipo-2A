<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TpWeb_Grupo2A.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
    </div>
    <div>
        <asp:Label Class="h1" ID="Label1" runat="server" Text="TERCER PASO: "></asp:Label>
        <asp:Label Class="h6" ID="Label2" runat="server" Text="Complete el formulario.."></asp:Label>
    </div>
    <div class="row g-3">
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Nombre</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="input_nombre"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label for="inputPassword4" class="form-label">Apellido</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="input_apellido"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label for="inputZip" class="form-label">Documento</label>
            <asp:TextBox runat="server" class="form-control" type="text" cssClass="form-control" ID="input_documento"></asp:TextBox>
        </div>
        <div class="col-12">
            <label for="inputAddress" class="form-label">Email</label>
            <asp:TextBox type="text" class="form-control" ID="input_email" runat="server"></asp:TextBox>
        </div>
        <div class="col-12">
            <label for="inputAddress2" class="form-label">Direccion</label>
            <asp:TextBox ID="input_direccion" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label for="inputCity" class="form-label">Ciudad</label>
            <asp:TextBox type="text" class="form-control" ID="input_ciudad" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-4">
            <label for="inputState" class="form-label">Localidad</label>
            <asp:TextBox ID="input_Localidad" class="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label for="inputZip" class="form-label">Codigo Postal</label>
            <asp:TextBox runat="server" type="text" class="form-control" ID="input_codigoPostal"></asp:TextBox>
        </div>
        <div class="col-12">
            <div class="form-check">
                <input class="form-check-input" type="checkbox" id="gridCheck">
                <label class="form-check-label" for="gridCheck">
                    Acepto los terminos y condiciones
                </label>
            </div>
        </div>
        <div class="col-12">
            <asp:Button ID="btnParticipar" CssClass="btn btn-primary" runat="server" Text="Participar" OnClick="btnParticipar_Click" />
        </div>
    </div>
</asp:Content>
