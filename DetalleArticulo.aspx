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
      <asp:Label ID="lbNombre" runat="server" Text='<%#Eval("Nombre_Articulo") %>' CssClass="card-Tittle"></asp:Label>
      <asp:Label ID="Lbprecio" runat="server" Text='<%#Eval("Precio") %>' CssClass="card-text"></asp:Label>
      <p class="card-descripcion"><%#Eval("_Descripcion") %></p>
      <p class="card-categoria"><%#Eval("des_categoria") %></p>
    <p class="card-marca"><%#Eval("des_marca") %></p>
    <a href="COMPRAR.aspx" class="btn btn-dark">Volver</a>
    <a href="CARRITO.aspx?id=<%#Eval("id") %>" class="btn btn-danger">Comprar</a>
    
     
        
  </div>
</div>

            </ItemTemplate>
</asp:Repeater>

    </div>
    </div>

    </asp:Content>