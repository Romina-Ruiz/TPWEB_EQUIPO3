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
            
             <asp:Repeater ID="rpCarrito" runat="server" >
                 <ItemTemplate> 
                    
                     <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                     <div class="col-md-4">
                     <img src="<%#Eval("urlImagen") %>" class="img-fluid rounded-start" alt="...">
                     
                     </div>
                    <div class="col-md-8">
                       <div class="card-body">
                         <asp:Label ID="lbNombre" runat="server" Text='<%#Eval("Nombre_Articulo") %>' CssClass="card-Tittle"></asp:Label>
                         <asp:Label ID="Lbprecio" runat="server" Text='<%#Eval("Precio") %>' CssClass="card-text"></asp:Label>

                            <br />  
                            <br />  
                            <br />  
                           <asp:Button Text="Eliminar" ID="btEliminar" CommandArgument='<%#Eval("id") %>' CommandName="Eliminar" class="btn btn-danger" OnCommand="btEliminar_Command" runat="server" />
                          
                      </div>
                    </div>
                    </div>
                </div>




                 </ItemTemplate>
             </asp:Repeater>

                




                    </div>

              </div>

        <div class="col-md-6"">
            <br />  
             <%   if(rpCarrito.Items.Count == 0){ %>
 <h5 cssclass="card-title">CARRITO VACIO DEBES AGREGAR UN ARTICULO</h5>
 <% } %>
            <a href="COMPRAR.aspx" class="btn btn-dark">VOLVER</a>
             
            <br />  
        </div>
      
       



</asp:Content>
