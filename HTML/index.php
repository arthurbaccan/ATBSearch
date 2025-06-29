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

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-4Q6Gf2aSP4eDXB8Miphtr37CMZZQ5oXLH2yaXMJ2w8e2ZtHTl7GptT4jmndRuHDT" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet">

    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="position.css">
    <link rel="stylesheet" href="defModel.css">
    <link rel="stylesheet" href="index.css">


    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@700&display=swap" rel="stylesheet">
    <link rel="shortcut icon" href="../Imagens/lupa-com-antibiotico.png" type="image/x-icon">

    <title>ATBSearch</title>
</head>

<body class="body-default" style="background: #dfdfdfee;">

    <style>
        h1,
        h2,
        h3,
        h4,
        h5,
        h6 {
            font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue",
                Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol";
            font-weight: 500;
            line-height: 1.2;
        }

        p {
            font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue",
               Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol";
        }
    </style>
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

    <br><br>

    <div class="container-inicio">

        <div class="div-inicial-accordion">
            <h1 class="titulo-inicial">ATBSearch</h1>

            <div class="accordion w-100" id="accordionInicio">
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                            data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                            Qual problema o sistema de saúde enfrenta?
                        </button>
                    </h2>
                    <div id="collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                        <div class="accordion-body">
                            <p>
                                O uso inadequado de antibióticos é um dos grandes desafios enfrentados pela
                                saúde
                                pública
                                atual,
                                contribuindo diretamente para o aumento da resistência microbiana e a redução da
                                eficácia
                                dos
                                tratamentos. Pensando nisso, esta plataforma foi desenvolvida para oferecer
                                suporte
                                a
                                profissionais
                                da
                                saúde, estudantes e pesquisadores na escolha racional e baseada em evidências de
                                antimicrobianos.
                            </p>
                        </div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse"
                            data-bs-target="#collapseTwo" aria-expanded="true" aria-controls="collapseTwo">
                            Como o ATBSearch pode ajudar?
                        </button>
                    </h2>
                    <div id="collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
                        <div class="accordion-body">

                            <p>
                                O ATBSearch é uma plataforma que reune, de forma organizada e acessível,
                                informações
                                atualizadas sobre
                                antibióticos disponíveis no mercado nacional, como sua classe farmacológica e
                                espectro
                                de
                                ação de acordo
                                com as carcaterísticas das bactérias alvo.
                                A consulta é facilitada por um sistema de tabelas com filtros inteligentes, que
                                permite
                                selecionar os
                                medicamentos com base em critérios como tipo e morfologia bacteriana, promovendo
                                maior
                                precisão
                                terapêutica.
                            </p>

                            <p>
                                A plataforma também foi planejada para ser acessível em diferentes contextos,
                                oferecendo
                                versões online e offline, com diferentes modalidades de uso — desde uma versão
                                gratuita
                                para
                                fins
                                acadêmicos até uma versão avançada voltada a instituições de saúde.
                            </p>

                            <p>
                                Ao integrar tecnologia da informação com fundamentos de farmacologia e gestão em
                                saúde,
                                esta
                                ferramenta busca contribuir diretamente para o enfrentamento da resistência
                                antimicrobiana e
                                para a
                                melhoria da segurança do paciente.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="image">
            <iframe width="100%" height="100%" src="https://www.youtube.com/embed/bhauokgjcdw?si=bNiwm-XSGZlctjq1"
                title="YouTube video player" frameborder="0"
                allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
                referrerpolicy="strict-origin-when-cross-origin" allowfullscreen>
            </iframe>
        </div>
    </div>

    <div class="carousel-container">

        <div class="card w-100 mb-3">
            <div class="card-body">
                <h4 class="card-title">Versão PRO</h4>
                <p class="card-text">Para ter acesso às tabelas personalizadas e a funcionamento offline com tabelas
                    e contas salvas
                    localmente, compre a versão PRO.
                    Ao efetuar a compra, você poderá baixar a versão para desktop e também acessar a página de
                    criação
                    de tabelas personalizadas no site.
                    Recomendamos os hospitais a usarem essa versão.</p>
                <div style="display: flex; justify-content: center;">
                    <button class="botao-versao-pro">
                        Versão PRO
                    </button>
                </div>

            </div>
        </div>

        <h2>Entenda os Filtros</h2>
        <p>As imagens abaixam mostram o que significam os filtros (classes de ATB, morfologias e Gram)</p>

        <div id="carouselExample" class="carousel slide carousel-bg" data-bs-theme="dark" data-bs-ride="carousel">
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <div class="carousel-image-item-container">
                        <img src="../Imagens/classes-antibioticos.png" class="carousel-image">
                    </div>

                </div>

                <div class="carousel-item">
                    <div class="carousel-image-item-container">
                        <img src="../Imagens/Bacterial_morphology_diagram-pt.svg.png" class="carousel-image">
                    </div>

                </div>
                <div class="carousel-item">
                    <div class="carousel-image-item-container">
                        <img src="../Imagens/GramPositivaGramNegativa.png" class="carousel-image">
                    </div>
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Anterior</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Próximo</span>
            </button>
        </div>

        <br>

        <h2>Painel Informativo</h2>
        <p>O painel abaixo apresenta dados de estudos que comprovam a importância do projeto e dados sobre nossa
            plataforma. Clique nos gráficos para interagir</p>

        <iframe title="ApresentacaoTCC-BancaJunho" class="powerBi" id="powerbi"
            src="https://app.powerbi.com/view?r=eyJrIjoiZWZiYzQ4N2QtNDVhMy00MTU4LWI1MzMtMmY1OGE2NmIwMjZlIiwidCI6ImI0NzQxYTgyLTZiNmUtNDNhNS1hZDZlLTEwNDQ1MTFhYWVkNiJ9"
            frameborder="0" allowFullScreen="true"></iframe>
        
    </div>

    <br>

    <div class="bottom-bar">
        <h2 style="text-align: center;">Integrantes da Equipe</h2>
        <div class="fotos-grupo">
            <div class="foto1">
                <span style="color: white;">
                    Arthur Buzas Baccan
                    <br>
                    Líder do projeto
                    <br>
                    Responsável pelo Desktop
                </span>
                <img src="../Imagens/Arthur.jpeg">
            </div>
            <div class="foto2">
                <span style="color: white;">
                    Lucas Antunes Soares
                    <br>
                    Responsável pelo App Mobile
                    <br>
                </span>
                <img src="../Imagens/Antunes.jpeg">
            </div>
            <div class="foto3">
                <span style="color: white;">
                    Natan Fontana
                    <br>
                    Responsável pelo Site - Web
                    <br>
                </span>
                <img src="../Imagens/Natan.jpeg">
            </div>
        </div>
        <br>
        <p class="trademark-bottom">© 2025 ATBSearch</p>
    </div>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-j1CDi7MgGQ12Z7Qab0qlWQ/Qqz24Gc6BM0thvEMVjHnfYGF0rmFCozFSxQBxwHKO"
        crossorigin="anonymous"></script>
</body>

</html>