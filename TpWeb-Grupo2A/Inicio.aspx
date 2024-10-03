<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="TpWeb_Grupo2A.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-3"></div>
        <div class="col">
            <div class="input-group mb-3">
                <span class="input-group-text">🎁</span>
                <div class="form-floating">
                    <asp:TextBox type="text" class="form-control" id="floatingInputGroup1" placeholder="Username" runat="server"></asp:TextBox>
                    <label for="floatingInputGroup1">Codigo</label>
                </div>
            </div>
            <asp:Button type="submit" class="btn btn-primary" ID="Button1" runat="server" Text="Validar" />
        </div>
        <div class="col-3"></div>
    </div>
    
</asp:Content>
