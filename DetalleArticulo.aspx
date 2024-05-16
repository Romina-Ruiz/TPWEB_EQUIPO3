<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="TPWEB_EQUIPO3.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="row justify-content-center">
        <div class="col-md-4"> 

<asp:Repeater runat="server" ID="rpArticulo">
    <ItemTemplate> 

<div class="card" >
  <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%#Eval("Nombre_Articulo") %></h5>
    <p class="card-text"><%#Eval("_Descripcion") %></p>
    <p class="card-text"><%#Eval("Precio") %></p>
    <p class="card-text"><%#Eval("des_categoria") %></p>
    <p class="card-text"><%#Eval("des_marca") %></p>
    <a href="COMPRAR.aspx" class="btn btn-outline-secondary">Volver</a>
    <a href="CARRITO.aspx?id=<%#Eval("id") %>"" class="btn btn-outline-primary">Agregar al carrito</a>
  </div>
</div>

            </ItemTemplate>
</asp:Repeater>

    </div>
    </div>

    </asp:Content>