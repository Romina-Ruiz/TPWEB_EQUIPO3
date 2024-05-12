<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="TPWEB_EQUIPO3.HOME" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
        .Fondo {
            background-color: burlywood;
            color: aliceblue;
            padding: 50px;
            text-align: center;
        }
    </style>


    <div class="Fondo">



        <h2>ESTAMOS EN EL HOME </h2>



    </div>



    <div>



        <div id="carouselExampleIndicators" class="carousel slide">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="https://www.bairesit.com.ar/Image/0/750_750-192.jpg" class="d-block w-70" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://www.torca.com.ar/thumb/000000000006320905780acel1_800x800.jpg" class="d-block w-70" alt="...">
                </div>
                <div class="carousel-item">
                    <img src="https://tienda.personal.com.ar/images/720/webp/Samsung_A04_E_32_negromin_f85db5dcea.png" class="d-block w-70" alt="...">
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>
    </div>






</asp:Content>
