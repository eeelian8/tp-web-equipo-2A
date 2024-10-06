<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TpWeb_Grupo2A.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div>
        <asp:Label Class="h1" ID="Label1" runat="server" Text="SEGUNDO PASO: "></asp:Label>
        <asp:Label Class="h6" ID="Label2" runat="server" Text="Seleccione su premio.."></asp:Label>
    </div>
    <br />
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <% foreach (Dominio.Articulo articulo in ListaArticulos)
            {
        %>
        <div class="col">
            <div class="card">
                <div id="<%: articulo.Codigo %>" class="carousel slide">
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img src="<%: articulo.Imagenes[0].Url %>" class="d-block w-100" alt="...">
                        </div>
                        <%foreach (Dominio.Imagen img in articulo.Imagenes)
                            {
                                if (img.Url != articulo.Imagenes[0].Url)
                                {%>
                        <div class="carousel-item">
                            <img src="<%: img.Url %>" class="d-block w-100" alt="...">
                        </div>
                        <%}
                            }%>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#<%: articulo.Codigo %>" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#<%: articulo.Codigo %>" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
                <div class="card-body">
                    <h5 class="card-title"><%: articulo.Nombre %></h5>
                    <p class="card-text"><%: articulo.Descripcion %></p>
                </div>
                <div class="card-body">
                    <small class="text-body-secondary"><%:"$" + articulo.Precio.ToString("N0", System.Globalization.CultureInfo.CurrentCulture)%></small>
                </div>
                <div class="card-footer">
                    <a href="Formulario.aspx?art=<%: articulo.Id %>" class="btn btn-primary">Seleccionar</a>
                </div>
            </div>
        </div>
        <%
            }
        %>
    </div>
</asp:Content>
