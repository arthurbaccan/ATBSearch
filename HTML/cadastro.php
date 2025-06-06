<?php
// Recebe as informações do formulario de cadastro
if (isset($_POST["submit"])) {

    $nome = $_POST["nome"];
    $email = $_POST["email"];
    $senha = $_POST["senha"];
    $telefone = $_POST["telefone"];

    
}


?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">

    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <title>Cadastro - Pesquisador de antibióticos</title>
</head>
<body class="body-form">
    <div class="center-absolute">
        <form class="form-default" action="cadastro.php" method="POST" id="form-cad-usuario">
            <div class="title-form">
                <img src="../Imagens/lupa-com-antibiotico.png" align="left"></img>
                <h2>ATBSearch</h2>
            </div>
            
            <div class="itens-form">
                <input id="nome" name="nome" class="inp-form " type="text" placeholder="Nome: *">
                <label id="valNome" name="valNome" class="text-validation-form">Preencha esse campo</label>
            </div>

            <div class="itens-form">
                <input id="email" name="email" class="inp-form " type="text" placeholder="Email: *">
                <label id="valEmail" name="valEmail" class="text-validation-form">Preencha esse campo</label>
            </div>
            
            <div class="itens-form">
                <input id="senha" name="senha" class="inp-form " type="password" placeholder="Senha: *">
                <label id="valSenha" name="valSenha" class="text-validation-form">Preencha esse campo</label>
            </div>

            <div class="itens-form">
                <input id="telefone" name="telefone" class="inp-form" type="text" placeholder="Telefone: (XX) XXXX-XXXX">
                <label id="valTelefone" name="valTelefone" class="text-validation-form">Insira um telefone válido</label>
            </div>

            <button id="cadastro" class="btn-form" type="submit" name="submit">Cadastrar</button>

            

            <h5 class="text-form">Já tem uma conta? <a class="link-blue" href="login.html">Login</a></h5>
            
        </form>

        
    </div>
    <script src="cadastro.js"></script>
</body>
</html>