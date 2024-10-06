<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="TpWeb_Grupo2A.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div>
        <asp:Label Class="h1" ID="Label1" runat="server" Text="TERCER PASO: "></asp:Label>
        <asp:Label Class="h6" ID="Label2" runat="server" Text="Complete el formulario.."></asp:Label>
    </div>
    <br />
    <div class="row g-3">
        <div class="col-md-6">
            <label for="inputEmail4" class="form-label">Nombre</label>
            <input type="text" class="form-control" id="inputEmail4">
        </div>
        <div class="col-md-6">
            <label for="inputPassword4" class="form-label">Apellido</label>
            <input type="text" class="form-control" id="inputPassword4">
        </div>
        <div class="col-12">
            <label for="inputAddress" class="form-label">Numero de documento</label>
            <input type="number" class="form-control" id="inputAddress" placeholder="XXXXXXXX">
        </div>
        <div class="col-12">
            <label for="inputAddress2" class="form-label">Email</label>
            <input type="email" class="form-control" id="inputAddress2" placeholder="ejemplo@mail.com">
        </div>
        <div class="col-md-6">
            <label for="inputCity" class="form-label">Ciudad</label>
            <input type="text" class="form-control" id="inputCity">
        </div>
        <div class="col-md-4">
            <label for="inputState" class="form-label">Localidad</label>
            <select id="inputState" class="form-select">
                <option selected>Seleccionar...</option>
                <option>...</option>
            </select>
        </div>
        <div class="col-md-2">
            <label for="inputZip" class="form-label">Codigo Postal</label>
            <input type="text" class="form-control" id="inputZip">
        </div>
        <div class="col-12">
            <div class="form-check">
                <input class="form-check-input" type="checkbox" id="gridCheck">
                <label class="form-check-label" for="gridCheck">
                    Acepto los terminos y condiciones
                </label>
            </div>
        </div>
        <button type="button" class="btn btn-success">Participar</button>
    </div>
</asp:Content>
