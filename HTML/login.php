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


	<title>Login - Pesquisador de antibióticos</title>

    <style>
        .password-like {
            -webkit-text-security: disc;
            /* Chrome, Safari */
        }
    </style>
</head>
<body class="body-form">
    <div class="center-absolute">
        <form class="form-default" id="form-log-usuario" method="POST" action="salvar-login.php">
            <div class="title-form">
                <img src="../Imagens/lupa-com-antibiotico.png" align="left"></img>
                <h2>ATBSearch</h2>
            </div>

            <div class="itens-form">
                <input id="emailOrPhone" name="emailOrPhone" class="inp-form " type="text" placeholder="Email ou telefone do usuário: *" value="natan@email.com">
                <label id="valEmailorPhone" name="valEmailOrPhone" class="text-validation-form">Insira um email ou telefone (com DDD) válido</label>
            </div>


            <div class="itens-form">
                <input id="senha" name="senha" class="inp-form password-like" type="text" placeholder="Senha: *" value="123456">
                <label id="valSenha" name="valSenha" class="text-validation-form">Insira uma senha válida </label>
            </div>

            <button id="cadastro" class="btn-form" type="button" onclick="validation()">Entrar</button>

            <br><br>

            <a class="link-blue" href="senha.html">Esqueci minha senha</a>

            <br><br>

            <h5 class="text-form">Não tem uma conta? <a class="link-blue" href="cadastro.php">Cadastrar-se</a></h5>

            <?php if (isset($_GET['erro'])): ?>
                <p class="erro-login" style="color: red; font-family: arial">E-mail, telefone ou senha incorretos.</p>
            <?php endif; ?>

            <h5 class="text-form"><a class="link-blue" href="index.php">Pagina Inicial</a></h5>
            
        </form>

        
    </div>

    <script src="login.js"></script>

</body>