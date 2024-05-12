<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="COMPRAR.aspx.cs" Inherits="TPWEB_EQUIPO3.COMPRAR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
        .Fondo {
            background-color: darkslategray;
            color: aliceblue;
            padding: 50px;
            text-align: center;
        }
    </style>


    <div class="Fondo">


        <h2>NUESTROS ARTICULOS</h2>


    </div>


    <div class="row row-cols-1 row-cols-md-3 g-4">


        <asp:Repeater ID="repArticulos" runat="server">
            <ItemTemplate>


                <div class="col">
                    <div class="card">
                        <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="Card title"><%#Eval("Nombre_Articulo") %></h5>
                            <p class="Card-text"><%#Eval("_Descripcion") %></p>
                        </div>

                    </div>



                </div>

            </ItemTemplate>
        </asp:Repeater>  


    </div>






</asp:Content>
