<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CATEGORIAS.aspx.cs" Inherits="TPWEB_EQUIPO3.CATEGORIAS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <style>
        .Fondo {
            background-color: cornflowerblue;
            color: aliceblue;
            padding: 50px;
            text-align:center;
        }
    </style>


    <div class="Fondo">


        <h2>CATEGORIAS </h2>


    </div>

    <div class="row row-cols-1 row-cols-md-3 g-4">


        <asp:Repeater ID="repRepetidor" runat="server">
            <ItemTemplate>


                <div class="col">
                    <div class="card">
                        <img src="https://img.freepik.com/foto-gratis/fondo-verde-liso-alta-calidad_53876-104893.jpg" class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class= "Card title"><%#Eval("Descripcion") %></h5>
                            <p class="Card-text"></p>
                        </div>

                    </div>



                </div>

            </ItemTemplate>
        </asp:Repeater>


    </div>

</asp:Content>


