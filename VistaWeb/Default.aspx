<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VistaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="Imgs/Carrusel/123.jpg" class="d-block w-100" alt="...">
                <div class="carousel-caption d-none d-md-block">
                    <h5>!Aprovecha el buen fin!</h5>
                    <p>Hasta 30% de descuento en todas nuestras salas</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Imgs/Carrusel/23.jpg" class="d-block w-100" alt="..." height="400px">
                <div class="carousel-caption d-none d-md-block">
                    <h5 class="text-dark">Precios de fabrica</h5>
                    <p class="text-dark">De la fabrica a tu casa</p>
                </div>
            </div>
            <div class="carousel-item">
                <img src="Imgs/Carrusel/Img.jpg" class="d-block w-100" alt="..." height="400px">
                <div class="carousel-caption d-none d-md-block">
                    <h5 class="text-dark">Las mejores salas de la ciudad</h5>
                    <p class="text-dark">Aprovecha nuestras promociones</p>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <br />
    <center><h1>Conoce nuestras salas</h1></center>
    <hr />
    <div class="row">
        <div class="card" style="width: 18rem;">
            <img src="Imgs/Cards/Sala.jpg" class="card-img-top zoom" alt="...">
            <div class="card-body">
                <center><h5 class="card-title">Sala Fancy</h5></center>
                <p class="card-text">Sala perfecta para lugares pequeños, ideal para 5 personas.</p>
                <a href="Enganche.aspx" class="btn btn-primary">Ir</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="Imgs/Cards/Sala1.jpg" class="card-img-top img-fluid zoom" alt="...">
            <div class="card-body">
                <center><h5 class="card-title">Manchester</h5></center>
                <p class="card-text">Sala sencilla, ideal para un espacio pequeño.</p>
                <a href="Enganche.aspx" class="btn btn-primary">Ir</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="Imgs/Cards/Sala2.jpg" class="card-img-top img-fluid zoom" alt="...">
            <div class="card-body">
                <center><h5 class="card-title">Late</h5></center>
                <p class="card-text">Sala sofisticada con detalles de lujo, ideal para grandes familias.</p>
                <a href="Enganche.aspx" class="btn btn-primary">Ir</a>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="Imgs/Cards/Sala3.jpg" class="card-img-top img-fluid zoom" alt="...">
            <div class="card-body">
                <center><h5 class="card-title">Pop</h5></center>
                <p class="card-text">Sala con colores divertidos, sillon con acabados sencillos.</p>
                <a href="Enganche.aspx" class="btn btn-primary">Ir</a>
            </div>
        </div>
    </div>

</asp:Content>
