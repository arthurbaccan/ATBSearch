<!DOCTYPE html>
<html lang="PT-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">

    <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css">


    <link rel="stylesheet" href="modBootstrap.css">

    <title>Document</title>
</head>

<style>
    body {
      overflow-x: hidden;
      background-color: #dfdfdfee;
    }

    .titulo {
      text-align: center;
      margin-top: 90px;
      margin-bottom: 8px;
    }
    
    @media (max-width: 630px) {
      .titulo {
        margin-top: 75px;
      }
    }

    @media (max-width: 510px) {
      .titulo {
        margin-top: 68px;
        font-size: 25px;
      }
    }

    @media (max-width: 378px) {
      .titulo {
        margin-top: 62px;
        font-size: 23px;
      }
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
            <a href="index.html">Início</a>
            <a href="contato.html">Contato</a>
            <a href="tabela-principal.php">Tabelas</a>
            <a href="cadastro.html">Cadastrar</a>
            <a href="login.html">Login</a>
        </div>
    </div>

    <!--<Itens de personalização-->
    <div class="navbar-table">
        <a href="#" class="nav-table-active">Filtrar Antibióticos</a>
        <a href="tabela.php" class="nav-table-no-active">Tabelas Personalizadas</a>
        <!--<a href="#" class="nav-table-no-active">Gerenciar Nuvem</a>-->
    </div>
    <br>
    <!--Tabela principal-->
    <h1 class="titulo">Filtrar Antibióticos</h1>
    
    <div style="overflow-x: auto; -webkit-overflow-scrolling: touch;">
      <table class="table-default">
        <tr>
          <thead>
            <th>

              Nome
              <!--Mostrar Filtros -->
              <button id="btnNome" type="button" class="btnFilter" onclick="mostrarFiltrosNome()">...</button>
              <!--Filtros: Nome-->
              <form id="filNome" class="filtro">
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (A-Z)</button>
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (Z-A)</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Ordem</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>
                <input type="text" class="inpText" placeholder="Pesquisar...">
                

                <!-- ok or cancel -->
                <div class="okOrCancel">
                  <button type="button" class="btnOk">OK</button>
                  <button type="button" class="btnCancel">Cancelar</button>
                </div> 

              </form>

            </th>
            
            <th>
              <label id="teste1">Tipo de Antibiótico</label>
              <!-- Mostrar Filtros -->
              <button id="btnAntibiotico" type="button" class="btnFilter" onclick="mostrarFiltrosAntibiotico()">...</button>
              <!-- Filtros: Tipo de Antibiótico -->
              <form id="filAntibiotico" class="filtro">
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (A-Z)</button>
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (Z-A)</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Ordem</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>
                <input type="text" class="inpText" placeholder="Pesquisar...">

                <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosAntibiotico" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoMacrolideos" type="checkbox" class="inpCheck"> Macrolídeos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoPenicilinas" type="checkbox" class="inpCheck"> Penicilinas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoCefalosporinas" type="checkbox" class="inpCheck"> Cefalosporinas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoCarbapenemicos" type="checkbox" class="inpCheck"> Carbapenêmicos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoAminoglicosideos" type="checkbox" class="inpCheck"> Aminoglicosídeos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoQuinolonas" type="checkbox" class="inpCheck"> Quinolonas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoAnfenicois" type="checkbox" class="inpCheck"> Anfenicóis
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoSulfonamidas" type="checkbox" class="inpCheck"> Sulfonamidas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoGlicopeptideos" type="checkbox" class="inpCheck"> Glicopeptídeos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoNitroimidazolicos" type="checkbox" class="inpCheck"> Nitroimdazólicos
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoLicosamidas" type="checkbox" class="inpCheck"> Licosamidas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoPolimixinas" type="checkbox" class="inpCheck"> Polimixinas
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoOxazolidinona" type="checkbox" class="inpCheck"> Oxazolidinona
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoGlicilciclina" type="checkbox" class="inpCheck"> Glicilciclina
                </div>

                <div class="selectChekBox">
                  <input id="checkAntibioticoAntituberculosos" type="checkbox" class="inpCheck"> Antituberculosos
                </div>

                </div>

                <!-- ok or cancel -->
                <div class="okOrCancel">
                  <button type="button" class="btnOk">OK</button>
                  <button type="button" class="btnCancel">Cancelar</button>
                </div> 

              </form>
            </th>
            
            <th>
              <label id="teste2">Ataca Gram Positiva</label>
              <!-- Mostrar Filtros -->
              <button id="btnGramPositiva" type="button" class="btnFilter" onclick="mostrarGramPositiva()">...</button>
              <!-- Filtros: Gram Positiva -->
              <form id="filGramPositiva" class="filtro">
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (A-Z)</button>
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (Z-A)</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Ordem</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

                <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosGramPositiva" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="checkGramPositivaYes" type="checkbox" class="inpCheck"> ✅
                </div>

                <div class="selectChekBox">
                  <input id="checkGramPositivaNo" type="checkbox" class="inpCheck"> ❌
                </div>

                </div>

                <!-- ok or cancel -->
                <div class="okOrCancel">
                  <button type="button" class="btnOk">OK</button>
                  <button type="button" class="btnCancel">Cancelar</button>
                </div> 

              </form>

            </th>

            <th>
              <label id="teste3">Ataca Gram Negativa</label>
              <!-- Mostrar Filtros -->
              <button id="btnGramNegativa" type="button" class="btnFilter" onclick="mostrarGramNegativa()">...</button>
              <!-- Filtros: Gram Negativa -->
              <form id="filGramNegativa" class="filtro">
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (A-Z)</button>
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (Z-A)</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Ordem</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

                <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosGramNegativa" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="checkGramNegativaYes" type="checkbox" class="inpCheck"> ✅
                </div>

                <div class="selectChekBox">
                  <input id="checkGramNegativaNo" type="checkbox" class="inpCheck"> ❌
                </div>

                </div>

                <!-- ok or cancel -->
                <div class="okOrCancel">
                  <button type="button" class="btnOk">OK</button>
                  <button type="button" class="btnCancel">Cancelar</button>
                </div> 

              </form>
            </th>
            
            <th>
              <label id="teste4">Morfologia</label>
              <!-- Mostrar Filtros -->
              <button id="btnMorfologia" type="button" class="btnFilter" onclick="mostrarMorfologia()">...</button>
              <!-- Filtros: Morfologia -->
              <form id="filMorfologia" class="filtro">
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (A-Z)</button>
                <button type="button" class="btnFilter2" onclick="">Ordem Alfabética (Z-A)</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Ordem</button>
                <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

                <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosMorfologia" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="checkMorfologiaBacilos" type="checkbox" class="inpCheck"> Bacilos
                </div>

                <div class="selectChekBox">
                  <input id="checkMorfologiaCocos" type="checkbox" class="inpCheck"> Cocos
                </div>

                <div class="selectChekBox">
                  <input id="checkMorfologiaCocosEBacilos" type="checkbox" class="inpCheck"> Cocos e Bacilos
                </div>

                </div>

                <!-- ok or cancel -->
                <div class="okOrCancel">
                  <button type="button" class="btnOk">OK</button>
                  <button type="button" class="btnCancel">Cancelar</button>
                </div> 

              </form>
            </th>

          </thead> 
        </tr>
                  
        <?php
          include 'tabelas.php';
          tabelaPrincipal($conn);
        ?>
          
      </table>
    </div>
      
    <script src="personalizar-tabela.js"></script>
</body>
</html>