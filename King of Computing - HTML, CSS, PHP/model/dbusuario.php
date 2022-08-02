<?php
    //LISTAR INFORMAÇÕES DO CLIENTE
    function listarInfoCliente($conexao){
        $query = "SELECT * FROM tbcliente WHERE emailCli LIKE '%{$_SESSION['emailCli']}%'";
        $resultados = mysqli_query($conexao, $query);
        $res = mysqli_fetch_array($resultados);
        return $res;
    
    }

    //VERIFICAR SENHA
    function verificarCliente($conexao, $emailCli, $senhaCli){
        $query = "SELECT * FROM tbcliente WHERE emailCli = '{$emailCli}'";
        $res = mysqli_query($conexao, $query);

        if(mysqli_num_rows($res) > 0){
            $row = mysqli_fetch_assoc($res);

            if(password_verify($senhaCli, $row["senhaCli"])){
                $_SESSION["emailCli"] = $row["emailCli"];

                return $row["emailCli"];
                
            }else{
                return "Senha não confere";
            }
        }
    }
?>