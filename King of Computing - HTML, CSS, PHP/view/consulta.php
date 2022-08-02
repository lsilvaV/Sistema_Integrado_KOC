<!DOCTYPE html>

<?php
session_start();

if (!$_SESSION["emailCli"]) {
    header("Location:../view/entrar.php");
}

include_once("../model/dbusuario.php");
include_once("../model/dbpedido.php");
include_once("../model/conexao.php");
?>

<html>

<head>
    <title>King of Computing</title>
    <link rel="shortcut icon" href="../view/img/icone.png">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="../view/css/estilocons.css">
    <link rel="icon" type="image/x-icon" href="../view/img/favicon.ico">
</head>

<body>
    <div class="cards">
        <div class="card">
            <div class="details">
                <h3> Visualizar Manutenção </h3>
                <form action="consulta.php" method="GET">
                    <div class="row center">
                </form>
            </div>

            <?php
            $cliente = listarInfoCliente($conexao);
            if ($cliente) {

            ?>
                <tbody>
                    <tr>
                        <h3 class="text"> Nome </h3>
                        <div class="escrita">
                            <td> <?= $cliente['nomeCli'] ?></td>
                        </div>

                        <h3 class="text"> Telefone </h3>
                        <div class="escrita">
                            <td> <?= $cliente['foneCli'] ?></td>
                        </div>
                    </tr>
                <?php
            }
                ?>
                </tbody>



                <!-- CONFIGURAÇÕES DO PEDIDO -->
                <?php
                $pedido = listaConfigPed($conexao);
                if ($pedido) {

                ?>
                    <tbody>
                        <tr>
                            <h3 class="text"> Data de Entrada </h3>
                            <div class="escrita">
                                <td> <?= $pedido['dataEnPed'] ?></td>
                            </div>
                        </tr>

                        <tr>
                            <h3 class="text"> Status </h3>
                            <div class="escrita">
                                <td> <?= $pedido['statusPed'] ?></td>
                            </div>
                        </tr>

                        <tr>
                            <h3 class="text"> Configurações </h3>
                            <div class="escrita2">
                                <td><?= $pedido['configPed'] ?></td>
                            </div>
                        </tr>

                    <?php
                }
                    ?>
                    </tbody>
                    <br>
                    <div class="link">
                        <a href="../view/index.php"> Página <br> Inícial </a>
                    </div>
        </div>
    </div>

    <br>


    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</body>

</html>