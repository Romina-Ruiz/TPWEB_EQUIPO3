﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="COMPRAR.aspx.cs" Inherits="TPWEB_EQUIPO3.COMPRAR" %>

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


        <asp:Repeater ID="repArticulos" runat="server" >
            <ItemTemplate>


                <div cssclass="col">
                    <div cssclass="card">
                        <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="...">
                        <div cssclass="card-body">
                            <h5 cssclass="Card title"><%#Eval("Nombre_Articulo") %></h5>
                            <p cssclass="Card-text"><%#Eval("_Descripcion") %></p>
                            <%--<asp:Button Text="Ver detalle" runat="server" OnClick="Unnamed_Click" CommandArgument='<%# Eval("ID") %>' />--%>
                            
                            <!-- Button trigger modal -->
                            <button type="button" cssclass="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
                                Ver detalles
                            </button>

                            <!-- Modal -->
                            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                <div class="modal-dialog">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h1 class="modal-title fs-5" id="exampleModalLabel"> 
                                                <h5 cssclass="Card title"><%#Eval("Nombre_Articulo") %></h5>
                                            </h1>
                                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                        </div>
                                        <div class="modal-body">
                                            ...
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" cssclass="btn btn-secondary" data-bs-dismiss="modal">Salir</button>
                                            <button type="button" cssclass="btn btn-primary">Agregar al carrito</button>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>

                    </div>



                </div>





            </ItemTemplate>

        </asp:Repeater>


    </div>






</asp:Content>
