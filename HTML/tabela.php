<?php
// Verifica se o cookie 'usuarios' existe e não está vazio
$logado = false;
if (isset($_COOKIE['usuarios'])) {
    $usuarios = json_decode($_COOKIE['usuarios'], true);
    if (!empty($usuarios)) {
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
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">

    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <link rel="stylesheet" href="modBootstrap.css">

    <title>Tabelas</title>
</head>

<style>
  body {
    overflow-x: hidden;
    background-color: #dfdfdfee;
  }
</style>

<body>
    <!--Navbar-->
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

    <!--<Itens de personalização-->
    <div class="navbar-table">
        <a href="tabela-principal.php" class="nav-table-no-active">Filtrar Antibióticos</a>
        <a href="#" class="nav-table-active">Tabelas Personalizadas</a>
        <!--<a href="#" class="nav-table-no-active">Gerenciar Nuvem</a>-->
    </div>

    <br><br><br><br>


      <!--Adicionar um conteiner responsivo que adiciona novas tabelas personalizadas em fileiras da esquerda pra direita e quebra para a próxma linha ao chegar no fim,
      Deve conter um botão de adicionar tabelar no canto superior esquerdo sempre,
      Lembrar de colocar uma excessão de java script pra evitar que seja possivel abrir mais de uma tabela personalizada ao mesmo tempo ao clicar rápido no botão,
      As tabelas personalizadas devem usar o mesmo banco de dados das tabelas convencionais-->
      <div style="display: flex; flex-wrap: wrap; align-items: center; gap: 0; align-itens: center; justify-content: center;">
        <div>
        <button id="add-table-button" class="table-add">
          +
        </button>
        </div>

        <!-- Depois de cada palavra SEMPRE COLOCAR UM ESPAÇO, mesmo que a próxima palavra seja colocada na próxma linha-->
        <div class="div-teste">  
          <button id="botao1" class="table-open">
            Tabela Personalizada
          </button>

          <button id="botao2" type="button" class="table-open-menu" onclick="menuActive()">
              <b>...</b>
          </button>

          <div id="menu-button" class="menu-button">
            <button>Deletar</button>
            <button>Renomear</button>
          </div>

        </div>

      </div>

      <script src="tabela.js"></script>

</body>

</html>