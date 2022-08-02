<?php
    //LISTAR CONFIGURAÇÕES DO PEDIDO
    function listaConfigPed($conexao){

        $cliente = listarInfoCliente($conexao);

        $query = "SELECT * FROM tbpedido WHERE idCliFK like '%{$cliente['idCli']}%'";
        $resultados = mysqli_query($conexao, $query);
        $res = mysqli_fetch_array($resultados);
        return $res;

    }

    //LISTAR STATUS DO PEDIDO
    function listaStatusPed($conexao){

        $cliente = listarInfoCliente($conexao);

        $query = "SELECT statusPed FROM tbpedido WHERE idCliFK like '%{$cliente['idCli']}%'";
        $resultados = mysqli_query($conexao, $query);
        $res = mysqli_fetch_array($resultados);
        return $res;

    }

?>