<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="TPWEB_EQUIPO3.HOME" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Models/StyHome.css" rel="stylesheet" />
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="Fondo">

        <h2>HOME PAGE </h2>


    </div>

    <div id="carouselExampleIndicators" class="carousel slide">
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
            <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
        </div>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://img.baba-blog.com/2024/02/consumer-electronics-market-in-united-kingdom_00.jpg?x-oss-process=style%2Ffull" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="https://revistadelconsumidor.files.wordpress.com/2010/12/marcas.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2018/11/50-regalos-tecnologicos-menos-50-euros.jpg?tf=3840x" class="d-block w-100" alt="...">
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
   
    
  <script>  
      function avanzarSlide() {
        document.querySelector('.carousel-control-prev').click();
      }
        
      setInterval(avanzarSlide, 5000);
   </script>


</asp:Content>
