<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MARCAS.aspx.cs" Inherits="TPWEB_EQUIPO3.MARCAS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <style>
        .Fondo {
            background-color: darkcyan;
            color: aliceblue;
            padding: 50px;
            text-align: center;
        }
    </style>


    <div class="Fondo">


        <h2>NUESTRAS MARCAS </h2>

             </div>

        <div class="row row-cols-1 row-cols-md-3 g-4">


            <asp:Repeater ID="RepetidorMarcas" runat="server">
                <ItemTemplate>


                    <div class="col">
                        <div class="card">
                            <img src="https://img.freepik.com/foto-gratis/fondo-textura-hormigon-liso-marron_53876-101719.jpg" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="Card title"><%#Eval("NombreMarca") %><h5>
                                <p class="Card-text"></p>
                            </div>

                        </div>



                    </div>

                </ItemTemplate>
            </asp:Repeater>


        </div>


    



</asp:Content>
