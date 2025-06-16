<?php
// Verifica se o cookie 'usuarios' existe e não está vazio
$logado  = false;
$usuario = null;

if (isset($_COOKIE['usuario'])) {
    $usuario = json_decode($_COOKIE['usuario'], true);
    if (!empty($usuario)) {
        $logado = true;
    }
}

$nomeUsuario = '';
if (isset($_COOKIE['usuario'])) {
    $usuario = json_decode($_COOKIE['usuario'], true);
    if (isset($usuario['nome'])) {
        $nomeUsuario = htmlspecialchars($usuario['nome']);
    }
}

$emailUsuario = '';
if (isset($_COOKIE['usuario'])) {
    $usuario = json_decode($_COOKIE['usuario'], true);
    if (isset($usuario['email'])) {
        $emailUsuario = htmlspecialchars($usuario['email']);
    }
}

$telefoneUsuario = '';
if (isset($_COOKIE['usuario'])) {
    $usuario = json_decode($_COOKIE['usuario'], true);
    if (isset($usuario['telefone']) && $usuario["telefone"] !== "") {
        $telefoneUsuario = htmlspecialchars($usuario['telefone']);
    }
    else{ 
        $telefoneUsuario = 'Não cadastrado';
    }
}
?>

<!DOCTYPE html>
<html lang="en">
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
    <title>ATBSearch - Conta</title>
</head>

<style>
    body {
      overflow-x: hidden;
      background-color: #dfdfdfee;
    }

    .titulo {
      text-align: center;
      margin-top: 40px;
      margin-bottom: 8px;
    }

    .nome-usuario {
        text-align: center;
        margin-top: 40px;
    }
    .info{
        margin-top: 40px;
        text-align: center;
    }
    .buttons{
        position: absolute;
        left: 50%;
        transform: translateX(-50%);
        margin-top: 20px;

        display: flex;
        flex-wrap: wrap;
        width: 430px;
        gap: 30px;

        button {
            width: 200px;
            height: 70px;

            font-size: 24px;
            border-radius: 5px;
            border: 1px solid gray;

            transition: 0.3s;
        }

        button:hover {
            background-color: var(--color-gray-light-hover);
        }
    }

    @media (max-width: 450px) {
        .buttons {
            width:280px;
            gap: 30px;

            button {
                width: 120px;
                height: 70px;

                font-size: 20px;
                border-radius: 5px;
                border: 1px solid gray;

                transition: 0.3s;
            }
        }
    }

    .buttons2 {
        width: 100%;
        display: flex;
        flex-wrap: wrap;
        margin-top: 20px;

        gap: 20px;

        button {
            margin-left: 5%;
            width: 90%;
            height: 70px;

            font-size: 24px;
            border-radius: 5px;
            border: 1px solid gray;

            transition: 0.3s;
        }

        button:hover {
            background-color: var(--color-gray-light-hover);
        }
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
            <a href="gerenciar-conta.php">Conta</a>
            <a href="logout.php">Sair</a>
        </div>
    </div>

    <br> <!-- BR DE ABSOLUTA IMPORTÂNCIA, SEM ELE O LAYOUT NÃO FUNCIONA -->
        
    <div class="titulo">
        <h1>Gerenciar Conta</h1>
    </div>

    <div class="nome-usuario">
        <h1>
            <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons/font/bootstrap-icons.css" rel="stylesheet">
            <i class="bi bi-person"></i><?= $nomeUsuario ?>
        </h1>
    </div>

    <div class="info">
        <div style="margin-bottom: 15px;">Email: <?= $emailUsuario ?></div>
        <div>Telefone: <?= $telefoneUsuario ?></div>
    </div>

    <div class="buttons">
        <button type="button">Trocar de conta</button>
        <button type="button">Mudar nome</button>
        <button type="button">Mudar senha</button>
        <button type="button">Mudar Telefone</button>
    </div>

    <div class="info" style="margin-top: 220px">
        <div>Número de tabelas personalizadas: 3</div>
    </div>

    <div class="buttons2">
        <button type="button" onclick="logout()">Sair</button>
        <button style="color: red">Deletar Conta</button>
    </div>

    <br>

    <script src="gerenciar-conta.js"></script>

</body>
</html>