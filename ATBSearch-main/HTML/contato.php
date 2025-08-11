<?php
$logado  = false;
$usuario = null;

if (isset($_COOKIE['usuario'])) {
    $usuario = json_decode($_COOKIE['usuario'], true);
    if (!empty($usuario)) {
        $logado = true;
    }
}
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">
    <link rel="stylesheet" href="teste.css">

    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <link rel="stylesheet" href="modBootstrap.css">

    <title>ATBSearch - Contato</title>
</head>

<style>

    body {
        background: linear-gradient(rgba(0, 0, 0, 0.4), rgba(0, 0, 0, 0.4)),url("../Imagens/antibioticos2.jpg");
        background-repeat: no-repeat;
        background-size: cover;
        backdrop-filter: blur(7px);
        height: 100vh;
    }

    div.container {
        display: flex;
        align-items: center;
        justify-content: center;
        
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);

        width: 80%;
        height: 57%;
        min-height: 422px;

        border: 2px solid #006494;
        border-radius: 0px;

        background-color: #006494;
    }

    div.container2 {
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 10%;

        border:4px solid white;
        width: 95%;
        height: 90%;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        position: absolute;
    }

    div.text-contato {
        display: flex;
        flex-direction: column;
        gap: 0;
        align-items: flex-start;
        justify-content: center;

        width: 38%;
        height: 225px;

        font-size: 32px;
        font-family: Arial, Helvetica, sans-serif;

        margin-bottom: 20px;

        color: white;
    }

    div.form-contato {
        display: flex;
        flex-direction: column;
        gap: 20px;

        .text-form {
            display: none;
            color: white;
            font-size: 30px;
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
        }

        .email {
            width: 400px;
            margin-bottom: 20px;

            border: 2px solid white;
            border-radius: 7px;
            outline: none;
        }

        .mensagem {
            width: 400px;
            height: 170px;
            margin-bottom: 20px;

            border: 2px solid white;
            border-radius: 7px;
            outline: none;
        }

        button {
            display: inline-block;
            outline: none;
            cursor: pointer;
            font-size: 14px;
            line-height: 1;
            border-radius: 500px;
            transition-property: background-color,border-color,color,box-shadow,filter;
            transition-duration: .3s;
            border: 1px solid transparent;
            letter-spacing: 2px;
            width: 250px;
            text-transform: uppercase;
            white-space: normal;
            font-weight: 700;
            text-align: center;
            padding: 16px 14px 18px;
            color: #006494;
            background-color: #ffffff;
            height: 48px;
            :hover{
                background-color: #495c4f;
            }}
    }

    @media (max-width: 1064px) {
        div.container {
            width: 55%;
            min-width: 467px;
        }

        div.container2 {
            height: 95%;
        }

        div.text-contato {
            display: none;
        }

        div.form-contato {
            .text-form {
                display: flex;
            }
        }
    }

    @media (max-width: 475px) {
        div.container {
            width: 318px;
            min-width: 0px;


        }

        div.form-contato {
            .email {
                width: 250px;
            }

            .mensagem {
                width: 250px;
            }
        }
    }

    /* Texto de validação do formulario*/
    .text-validation-form {
        display: none;
        margin: 0 0 10px 0;
        padding: 0px 5px 0px 5px;

        color: red;
        font-family: Arial, Helvetica, sans-serif;
        font-weight: none;
        font-size: 14px;
        background-color: white;
        border-radius: 0px 0px 5px 5px;
    }


</style>

<body>

    <div class="navbar">
        <div class="nav-left">
            <img src="../Imagens/lupa-com-antibiotico.png">
            ATBSearch
        </div>

        <div class="nav-right">
            <a href="index.php">Início</a>
            <a href="contato.php">Contato</a>
            <a href="tabela-principal.php">Tabelas</a>
            
            <!-- Modifica a navbar dependendo do usuário estar ou não logado-->
            <?php if ($logado): ?>
                <a href="gerenciar-conta.php">Conta</a>
                <a href="logout.php">Sair</a>
            <?php else: ?>
                <a href="cadastro.php">Cadastrar</a>
                <a href="login.php">Login</a>
            <?php endif; ?>
        </div>
    </div>

    
    <div class="container">
        <div class="container2">
            <div class="text-contato">
                <label style="font-size: 45px; font-weight: bold; padding: 0; margin: 0;">Fale conosco!</label>
                Para receber nossa ajuda, preencha o formulário a seguir e use o botão de enviar para que possamos recebê-la
            </div>

            <div class="form-contato">
                <form id="form-contato" style="display: flex; flex-direction: column; align-items: center;">
                    <label class="text-form">Fale conosco!</label>
                    <input id="email" type="text" class="email" placeholder="usuario@email.com">
                    <label id="valEmail" name="valEmail" class="text-validation-form">Preencha esse campo corretamente</label>
                    <textarea id="mensagem" class="mensagem" placeholder="Digite sua mensagem aqui"></textarea>
                    <label id="valMensagem" name="valMensagem" class="text-validation-form">Preencha esse campo</label>
                    <button type="button" onclick="validation()">Enviar</button>
                </form>
            </div>
        </div>
    </div>

    <script src="contato.js"></script>

</body>
</html>