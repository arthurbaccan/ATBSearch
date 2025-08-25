<?php
$logado = false;
$usuario = null;

if (isset($_COOKIE['usuario'])) {
  $usuario = json_decode($_COOKIE['usuario'], true);
  if (!empty($usuario)) {
    $logado = true;
  }
}

$TipoAntibiotico = array(
  "MACROLIDEOS" => "Macrolídeos",
  "PENICILINAS" => "Penicilinas",
  "CEFALOSPORINAS" => "Cefalosporinas",
  "CARBAPENEMICOS" => "Carbapenêmicos",
  "AMINOGLICOSIDEOS" => "Aminoglicosídeos",
  "QUINOLONAS" => "Quinolonas",
  "ANFENICOIS" => "Anfenicóis",
  "SULFONAMIDAS" => "Sulfonamidas",
  "GLICOPEPTIDEOS" => "Glicopeptídeos",
  "NITROIMIDAZOLICOS" => "Nitroimdazólicos",
  "LICOSAMIDAS" => "Licosamidas",
  "POLIMIXINAS" => "Polimixinas",
  "OXAZOLIDINONA" => "Oxazolidinona",
  "GLICILCICLINA" => "Glicilciclina",
  "ANTITUBERCULOSOS" => "Antituberculosos"
);

$checkBoxFiltroComecoId = "checkAntibiotico";
$checkGramPositivaYesId = "checkGramPositivaYes";
$checkGramPositivaNoId = "checkGramPositivaNo";
$checkGramNegativaYesId = "checkGramNegativaYes";
$checkGramNegativaNoId = "checkGramNegativaNo";
$checkCoccosId = "checkCoccos";
$checkCoccosBacilosId = "checkCoccosBacilos";
$checkBacilosId = "checkBacilos";

?>

<!DOCTYPE html>
<html lang="PT-BR">

<head>
  <script>
    var TipoAntibiotico = Object.freeze(<?php echo json_encode($TipoAntibiotico); ?>);
    var checkBoxFiltroComecoId = "<?php echo $checkBoxFiltroComecoId; ?>";
    <?php
    include 'tabelas.php';
    //tabelaPrincipal($conn);
    ?>
    var jsonDados = <?php obterDadosAntibioticos($conn2); ?>;
    const jsonDadosOriginal = Array.from(jsonDados);
    const checkGramPositivaYesId = "<?php echo $checkGramPositivaYesId; ?>";
    const checkGramPositivaNoId = "<?php echo $checkGramPositivaNoId; ?>";
    const checkGramNegativaYesId = "<?php echo $checkGramNegativaYesId; ?>";
    const checkGramNegativaNoId = "<?php echo $checkGramNegativaNoId; ?>";
    const checkCoccosId = "<?php echo $checkCoccosId; ?>";
    const checkCoccosBacilosId = "<?php echo $checkCoccosBacilosId; ?>";
    const checkBacilosId = "<?php echo $checkBacilosId; ?>";
  </script>

  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
    integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

  <link rel="stylesheet" href="style.css">
  <link rel="stylesheet" href="position.css">
  <link rel="stylesheet" href="defModel.css">

  <link href="https://fonts.googleapis.com/css2?family=League+Spartan:wght@400;700&display=swap" rel="stylesheet">
  <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
  <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css">


  <link rel="stylesheet" href="modBootstrap.css">

  <script src="personalizar-tabela.js"></script>

  <title>ATBSearch - Tabela Princpal</title>
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
    <a href="#" class="nav-table-active">Filtrar Antibióticos</a>

    <?php if ($logado): ?>
      <a href="tabela.php" class="nav-table-no-active">Tabelas Personalizadas</a>
    <?php else: ?>
      <label></label>
    <?php endif; ?>

    <!--<a href="#" class="nav-table-no-active">Gerenciar Nuvem</a>-->
  </div>
  <br>
  <!--Tabela principal-->
  <h1 class="titulo">Filtrar Antibióticos</h1>

  <div style="overflow-x: auto; -webkit-overflow-scrolling: touch; min-height: 350px;">
    <table class="table-default">
      <tr>
        <thead>
          <th>

            Nome
            <!--Mostrar Filtros -->
            <button id="btnNome" type="button" class="btnFilter" onclick="mostrarFiltrosNome()">...</button>
            <!--Filtros: Nome-->
            <form id="filNome" class="filtro">
              <button type="button" class="btnFilter2" onclick="clickAZNome(jsonDados)">Ordem Alfabética (A-Z)</button>
              <button type="button" class="btnFilter2" onclick="clickZANome(jsonDados)">Ordem Alfabética (Z-A)</button>
              <button type="button" class="btnFilter2" onclick="limparOrdem(jsonDadosOriginal, jsonDados)">Limpar Ordem</button>
              <input type="text" id="pesquisarNome" class="inpText" oninput="filtrarNomeInput(jsonDados, jsonDadosOriginal)" placeholder="Pesquisar...">

            </form>

            <script>
              const form = document.getElementById("filNome");

              form.addEventListener("submit", function(event) {
                // impede o envio
                event.preventDefault();
              });
            </script>

          </th>

          <th>
            <label id="teste1">Tipo de Antibiótico</label>
            <!-- Mostrar Filtros -->
            <button id="btnAntibiotico" type="button" class="btnFilter"
              onclick="mostrarFiltrosAntibiotico()">...</button>
            <!-- Filtros: Tipo de Antibiótico -->
            <form id="filAntibiotico" class="filtro" onkeydown="asteca(event)">
              <button type="button" class="btnFilter2" onclick="clickAZTipoAntibiotico(jsonDados)">Ordem Alfabética (A-Z)</button>
              <button type="button" class="btnFilter2" onclick="clickZATipoAntibiotico(jsonDados)">Ordem Alfabética (Z-A)</button>
              <button type="button" class="btnFilter2" onclick="limparOrdem(jsonDadosOriginal, jsonDados)">Limpar Ordem</button>
              <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>
              <input type="text" class="inpText" placeholder="Pesquisar..." onkeydown="asteca(event)">

              <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosAntibiotico" type="checkbox" class="inpCheck" onchange=""> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["MACROLIDEOS"]; ?>" checked type="checkbox" class="inpCheck"> Macrolídeos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["PENICILINAS"]; ?>" checked type="checkbox" class="inpCheck"> Penicilinas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["CEFALOSPORINAS"]; ?>" checked type="checkbox" class="inpCheck"> Cefalosporinas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["CARBAPENEMICOS"]; ?>" checked type="checkbox" class="inpCheck"> Carbapenêmicos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["AMINOGLICOSIDEOS"]; ?>" checked type="checkbox" class="inpCheck"> Aminoglicosídeos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["QUINOLONAS"]; ?>" type="checkbox" checked class="inpCheck"> Quinolonas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["ANFENICOIS"]; ?>" type="checkbox" checked class="inpCheck"> Anfenicóis
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["SULFONAMIDAS"]; ?>" type="checkbox" checked class="inpCheck"> Sulfonamidas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["GLICOPEPTIDEOS"]; ?>" type="checkbox" checked class="inpCheck"> Glicopeptídeos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["NITROIMIDAZOLICOS"]; ?>" type="checkbox" checked class="inpCheck"> Nitroimdazólicos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["LICOSAMIDAS"]; ?>" type="checkbox" checked class="inpCheck"> Licosamidas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["POLIMIXINAS"]; ?>" type="checkbox" checked class="inpCheck"> Polimixinas
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["OXAZOLIDINONA"]; ?>" type="checkbox" checked class="inpCheck"> Oxazolidinona
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["GLICILCICLINA"]; ?>" type="checkbox" checked class="inpCheck"> Glicilciclina
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBoxFiltroComecoId . $TipoAntibiotico["ANTITUBERCULOSOS"]; ?>" type="checkbox" checked class="inpCheck"> Antituberculosos
                </div>
              </div>

              <!-- ok or cancel -->
              <div class="okOrCancel">
                <button type="button" class="btnOk" onclick="okClickedTipo(jsonDados, jsonDadosOriginal)">OK</button>
                <button type="button" class="btnCancel" onclick="cancelarClickedTipo(jsonDados)">Cancelar</button>
              </div>

            </form>

            <script>
              const asd = document.getElementById("filAntibiotico");

              asd.addEventListener("submit", function(event) {
                // impede o envio
                event.preventDefault();
              });
            </script>


          </th>

          <th>
            <label id="teste2">Ataca Gram Positiva</label>
            <!-- Mostrar Filtros -->
            <button id="btnGramPositiva" type="button" class="btnFilter" onclick="mostrarGramPositiva()">...</button>
            <!-- Filtros: Gram Positiva -->
            <form id="filGramPositiva" class="filtro">
              <button type="button" class="btnFilter2" onclick="clickAZGramPositiva(jsonDados)">Ordem Alfabética (A-Z)</button>
              <button type="button" class="btnFilter2" onclick="clickZAGramPositiva(jsonDados)">Ordem Alfabética (Z-A)</button>
              <button type="button" class="btnFilter2" onclick="limparOrdem(jsonDadosOriginal, jsonDados)">Limpar Ordem</button>
              <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

              <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosGramPositiva" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkGramPositivaYesId; ?>" type="checkbox" checked class="inpCheck"> ✅
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkGramPositivaNoId; ?>" type="checkbox" checked class="inpCheck"> ❌
                </div>

              </div>

              <!-- ok or cancel -->
              <div class="okOrCancel">
                <button type="button" class="btnOk" onclick="okClickedGramPositiva(jsonDados, jsonDadosOriginal)">OK</button>
                <button type="button" class="btnCancel" onclick="cancelarClickedGramPositiva(jsonDados)">Cancelar</button>
              </div>

            </form>

          </th>

          <th>
            <label id="teste3">Ataca Gram Negativa</label>
            <!-- Mostrar Filtros -->
            <button id="btnGramNegativa" type="button" class="btnFilter" onclick="mostrarGramNegativa()">...</button>
            <!-- Filtros: Gram Negativa -->
            <form id="filGramNegativa" class="filtro">
              <button type="button" class="btnFilter2" onclick="clickAZGramNegativa(jsonDados)">Ordem Alfabética (A-Z)</button>
              <button type="button" class="btnFilter2" onclick="clickZAGramNegativa(jsonDados)">Ordem Alfabética (Z-A)</button>
              <button type="button" class="btnFilter2" onclick="limparOrdem(jsonDadosOriginal, jsonDados)">Limpar Ordem</button>
              <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

              <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosGramNegativa" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkGramNegativaYesId; ?>" checked type="checkbox" class="inpCheck"> ✅
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkGramNegativaNoId; ?>" checked type="checkbox" class="inpCheck"> ❌
                </div>

              </div>

              <!-- ok or cancel -->
              <div class="okOrCancel">
                <button type="button" class="btnOk" onclick="okClickedGramNegativa(jsonDados, jsonDadosOriginal)">OK</button>
                <button type="button" class="btnCancel" onclick="cancelarClickedGramNegativa(jsonDados)">Cancelar</button>
              </div>

            </form>
          </th>

          <th>
            <label id="teste4">Morfologia</label>
            <!-- Mostrar Filtros -->
            <button id="btnMorfologia" type="button" class="btnFilter" onclick="mostrarMorfologia()">...</button>
            <!-- Filtros: Morfologia -->
            <form id="filMorfologia" class="filtro" style="right: 0">
              <button type="button" class="btnFilter2" onclick="clickAZMorfologia(jsonDados)">Ordem Alfabética (A-Z)</button>
              <button type="button" class="btnFilter2" onclick="clickZAMorfologia(jsonDados)">Ordem Alfabética (Z-A)</button>
              <button type="button" class="btnFilter2" onclick="limparOrdem(jsonDadosOriginal, jsonDados)">Limpar Ordem</button>
              <button type="button" class="btnFilter2" onclick="">Limpar Filtro</button>

              <div class="containerCheckBox">
                <div class="selectChekBox">
                  <input id="selecionarTodosMorfologia" type="checkbox" class="inpCheck"> Selecionar Todos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkBacilosId; ?>" type="checkbox" checked class="inpCheck"> Bacilos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkCoccosId; ?>" type="checkbox" checked class="inpCheck"> Cocos
                </div>

                <div class="selectChekBox">
                  <input id="<?php echo $checkCoccosBacilosId; ?>" type="checkbox" checked class="inpCheck"> Cocos e Bacilos
                </div>

              </div>

              <!-- ok or cancel -->
              <div class="okOrCancel">
                <button type="button" class="btnOk" onclick="okClickedMorfologia(jsonDados, jsonDadosOriginal)">OK</button>
                <button type="button" class="btnCancel" onclick="cancelarClickMorfologia(jsonDados)">Cancelar</button>
              </div>

            </form>
          </th>

        </thead>
      </tr>
      <tbody id="tabela">


        <script>
          console.log(jsonDados)

          gerarTabelaAntibioticos(jsonDados);
        </script>

      </tbody>
    </table>
  </div>

</body>

</html>