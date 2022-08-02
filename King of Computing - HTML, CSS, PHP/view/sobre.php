<!DOCTYPE html>

<?php
    session_start();
    if(!$_SESSION["emailCli"]){
        header("Location:../view/entrar.php");
    }
?>

<html>

<head>
    <title> King of Computing </title>
    <link rel="shortcut icon" href="../view/img/icone.png">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="../view/css/estilosobre.css">
    <link rel="icon" type="image/x-icon" href="../view/img/favicon.ico">
</head>

<body>
    <div class="cards">
        <div class="card card1">
            <div class="container">
                <img src="../view/img/sobre1.jpg">
            </div>

            <div class="details">
                <h3> Sobre </h3>
                <p> Nossa empressa foi criada no dia 02/05/2021, com uma ideia base de ajudar as pessoas que precisam de auxílio com a manutenção de seus computadores, no inicio eram só ideias. Com o nosso conhecimento em informática, decidimos ajudar as pessoas que necessitam de manutenções em seus computadores. Em poucas palavras nossa empresa veio para facilitar o trabalho de muitas pessoas, somos uma organização que quer valores justos para todos e sempre queremos uma melhor comunicação com os clientes. </p>
            </div>

        </div>

        <div class="card card2">
            <div class="container">
                <img src="../view/img/sobre2.jpg">
            </div>

            <div class="details">
                <h3> Visão </h3>
                <p class="visao"> A empressa King of Computing esta em constante desenvolvimento para ser referência e ser reconhecida por serviços inovadores. Nossa organização tem valores bem sólidos como trabalho em equipe, respeito entre as pessoas, responsabilidade, honestidade, empatia, inovação, originalidade e organização. </p>
            </div>
        </div>

        <div class="card card3">
            <div class="container">
                <img src="../view/img/sobre3.jpg">
            </div>

            <div class="details">
                <h3> Onde deseja ir? </h3>

                <div class="link">
                    <a href="../view/index.php"> Página Inícial </a>
                </div>
                <div class="link">
                    <a href="../view/info.php"> Informações </a>
                </div>
                <div class="link">
                    <a href="../model/logout.php"> Sair </a>
                </div>
            </div>

        </div>

    </div>

</body>

</html>
