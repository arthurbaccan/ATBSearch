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
        <a href="#" class="nav-table-active">Tabelas Personalizadas</a>
        <!--<a href="#" class="nav-table-no-active">Gerenciar Nuvem</a>-->
    </div>


      <!--Adicionar um conteiner responsivo que adiciona novas tabelas personalizadas em fileiras da esquerda pra direita e quebra para a próxma linha ao chegar no fim,
      Deve conter um botão de adicionar tabelar no canto superior esquerdo sempre,
      Lembrar de colocar uma excessão de java script pra evitar que seja possivel abrir mais de uma tabela personalizada ao mesmo tempo ao clicar rápido no botão,
      As tabelas personalizadas devem usar o mesmo banco de dados das tabelas convencionais-->
      <div style="display: flex; align-items: center;">
        <button id="add-table-button" class="table-add">
          +
        </button>

        <!-- Depois de cada palavra SEMPRE COLOCAR UM ESPAÇO, mesmo que a próxima palavra seja colocada na próxma linha-->
          <button id="botao1" class="table-open">
            aaaaaaaaaaaa 
            aaaaaaaaa 
            aaaaaaaaaaaaa 

            <button id="botao2" class="table-open-menu">
              <b>...</b>
            </button>
          </button>
      </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <script src="tabela.js"></script>

</body>

<script>
document.getElementById("botao1").addEventListener("mouseover", hoverDarkGreen);
function hoverDarkGreen() {
  document.getElementById("botao2").style.transition = "0.5s"
  document.getElementById("botao2").style.backgroundColor = "darkgreen";
  
}

document.getElementById("botao1").addEventListener("mouseleave", hoverDarkGreen2);
function hoverDarkGreen2() {
  document.getElementById("botao2").style.backgroundColor = "green";
  
}

document.getElementById("botao2").addEventListener("mouseover", hoverGray);
function hoverGray() {
  document.getElementById("botao2").style.transition = "0.5s"
  document.getElementById("botao2").style.backgroundColor = "#85a187";
  document.getElementById("botao2").style.borderRadius = "5px";  
}

document.getElementById("botao2").addEventListener("mouseleave", hoverGray2);
function hoverGray2() {
  document.getElementById("botao2").style.backgroundColor = "green";
}
</script>

</html>