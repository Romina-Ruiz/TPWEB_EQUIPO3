<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CARRITO.aspx.cs" Inherits="TPWEB_EQUIPO3.CARRITO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <style>
        .Fondo {
            background-color: darkgray;
            color: aliceblue;
            padding: 50px;
            text-align: center;
        }
    </style>


    <div class="Fondo">


        <h2>CARRITO </h2>

    </div>



    <div class="table-secondary">
         <div class="col-sm-9 p-3">
             
        <asp:GridView ID="dgvCarrito" DataKeyNames="Id" OnSelectedIndexChanged="dgvCarrito_SelectedIndexChanged" runat="server" cssClass="table table-secondary dark" AutoGenerateColumns="false">
                      
 
            <columns>

             
                <asp:BoundField HeaderText="Nombre" DataField="Nombre_Articulo"/>
                <asp:BoundField HeaderText="Precio" DataField="Precio"/>
                <asp:Commandfield ShowSelectButton="true" SelectText="Eliminar Articulo" HeaderText="Accion"/>


                        </columns>
                         
              
        </asp:GridView>
              </div>

        <div class="col-md-4"">
              
            <a href="COMPRAR.aspx" class="btn btn-dark">VOLVER</a>

        </div>
      


    </div>









</asp:Content>
