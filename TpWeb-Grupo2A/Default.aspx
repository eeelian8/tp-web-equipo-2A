<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpWeb_Grupo2A.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="input-group mb-3">
                <span class="input-group-text">🎁</span>
                <div class="form-floating">
                    <asp:TextBox type="text" class="form-control" ID="input_codigo" placeholder="Username" runat="server" OnTextChanged="input_codigo_TextChanged"></asp:TextBox>
                    <label for="floatingInputGroup1">Codigo</label>
                </div>
            </div>
            <asp:Button type="submit" OnClick="btn_codigo_Click" Class="btn btn-primary" ID="btn_codigo" runat="server" Text="Validar" />
        </div>
        <div class="col-3"></div>
    </div>
    
</asp:Content>
