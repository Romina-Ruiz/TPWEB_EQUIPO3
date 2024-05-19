<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CARRITO.aspx.cs" Inherits="TPWEB_EQUIPO3.CARRITO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <style>
        .Fondo {
            background-color: brown;
            color: aliceblue;
            padding: 50px;
            text-align: center;
        }
    </style>


    <div class="Fondo">


        <h2>CARRITO </h2>

    </div>



    <div>
         <div class="col-sm-9 p-3">
        <asp:GridView ID="dgvCarrito" DataKeyNames="Id" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged" runat="server" CssClass="table" AutoGenerateColumns="false">
                      
 
            <columns>

             
                <asp:BoundField HeaderText="Nombre" DataField="Nombre_Articulo"/>
                <asp:BoundField HeaderText="Precio" DataField="Precio"/>
                <asp:Commandfield ShowSelectButton="true" SelectText="Eliminar Articulo" HeaderText="Accion"/>


                        </columns>
                         
              
        </asp:GridView>
              </div>

        <a href="COMPRAR.aspx" class="btn btn-secondary">Volver</a>


    </div>









</asp:Content>
