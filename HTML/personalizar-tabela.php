<!DOCTYPE html>
<html lang="PT-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">
    <link rel="stylesheet" href="personalizar-tabela.css">

    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <link rel="stylesheet" href="modBootstrap.css">

    <title>Personalizar tabela</title>
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
            <a href="index.html">Menu</a>
            <a href="contato.html">Contato</a>
            <a href="tabela-principal.php">Tabelas</a>
            <a href="cadastro.html">Cadastrar</a>
            <a href="login.html">Login</a>
        </div>
    </div>

    <!--<Itens de personalização-->
    <div class="navbar-table">
        <a href="tabela-principal.php" class="nav-table-no-active">Filtrar Antibióticos</a>
        <a href="tabela.php" class="nav-table-no-active">Tabelas Personalizadas</a>
        <a href="#" class="nav-table-no-active">Gerenciar Nuvem</a>
    </div>
    <br>

    <h1 style="text-align: center; margin-top: 100px; margin-buttom: 0px"></h1>


      <div class="itens-pesquisa">
        <div>
          <form>
            <b>Nome da Tabela</b>
            <input type="text" class="nome">
          </form>
        </div>

        <div>
          <button type="button">Marcar Todos</button>
          <button type="button">Desmarcar Todos</button>
          <button type="button">Criar Tabela</button>
        </div>
        
        
      </div>
      
      <!--Tabela Principal para selecionar os itens que estarão na tabela personalizada-->
      <table class="table-default">
      
        <tr>
          <th>Nome <button type="button">...</button></th>
          <th><label id="teste1">Tipo de Antibiótico</label> <button type="button">...</button></th>
          <th><label id="teste2">Ataca Gram Positiva</label> <button type="button">...</button></th>
          <th><label id="teste3">Ataca Gram Negativa</label> <button type="button">...</button></th>
          <th><label id="teste4">Morfologia</label> <button type="button">...</button></th>
        </tr>
                
        <?php include 'tabelas.php'; ?>
        
      </table>
      
    <script src="personalizar-tabela.js"></script>
</body>
</html>