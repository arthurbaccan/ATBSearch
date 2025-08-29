/*responsividade da tabela*/
function verificarTamanhoTela() {
    if (window.innerWidth < 1300) {
        document.getElementById("teste1").textContent = "Antibiótico";
        document.getElementById("teste2").textContent = "Gram Positiva";
        document.getElementById("teste3").textContent = "Gram Negativa";
        document.getElementById("teste4").textContent = "Moforlogia";
    }
    else {
        document.getElementById("teste1").textContent = "Tipo de Antibiótico";
        document.getElementById("teste2").textContent = "Ataca Gram Positiva";
        document.getElementById("teste3").textContent = "Ataca Gram Negativa";
        document.getElementById("teste4").textContent = "Moforlogia";
    }
}

window.addEventListener('resize', verificarTamanhoTela);
verificarTamanhoTela();

/*função para mostrar filtros: Nome*/
var displayFlexNome = false;
function mostrarFiltrosNome() {

    if (displayFlexNome == false) {
        document.getElementById("filNome").style.display = "flex";
        displayFlexNome = true;

        displayFlexAntibiotico = false;
        document.getElementById("filAntibiotico").style.display = "none";

        displayFlexGramPositiva = false;
        document.getElementById("filGramPositiva").style.display = "none";

        displayFlexGramNegativa = false;
        document.getElementById("filGramNegativa").style.display = "none";

        displayFlexMorfologia = false;
        document.getElementById("filMorfologia").style.display = "none";
    }
    else {
        document.getElementById("filNome").style.display = "none";
        displayFlexNome = false;
    }

}

/*função para mostrar filtros: Antibiotico*/
var displayFlexAntibiotico = false;
function mostrarFiltrosAntibiotico() {

    if (displayFlexAntibiotico == false) {
        document.getElementById("filAntibiotico").style.display = "flex";
        displayFlexAntibiotico = true;

        displayFlexNome = false;
        document.getElementById("filNome").style.display = "none";

        displayFlexGramPositiva = false;
        document.getElementById("filGramPositiva").style.display = "none";

        displayFlexGramNegativa = false;
        document.getElementById("filGramNegativa").style.display = "none";

        displayFlexMorfologia = false;
        document.getElementById("filMorfologia").style.display = "none";
    }
    else {
        document.getElementById("filAntibiotico").style.display = "none";
        displayFlexAntibiotico = false;
    }

}

/*função para mostrar filtros: Gram Positiva*/
var displayFlexGramPositiva = false;
function mostrarGramPositiva() {

    if (displayFlexGramPositiva == false) {
        document.getElementById("filGramPositiva").style.display = "flex";
        displayFlexGramPositiva = true;

        displayFlexNome = false;
        document.getElementById("filNome").style.display = "none";

        displayFlexAntibiotico = false;
        document.getElementById("filAntibiotico").style.display = "none";

        displayFlexGramNegativa = false;
        document.getElementById("filGramNegativa").style.display = "none";

        displayFlexMorfologia = false;
        document.getElementById("filMorfologia").style.display = "none";
    }
    else {
        document.getElementById("filGramPositiva").style.display = "none";
        displayFlexGramPositiva = false;
    }

}

/*função para mostrar filtros: Gram Negativa*/
var displayFlexGramNegativa = false;
function mostrarGramNegativa() {

    if (displayFlexGramNegativa == false) {
        document.getElementById("filGramNegativa").style.display = "flex";
        displayFlexGramNegativa = true;

        displayFlexNome = false;
        document.getElementById("filNome").style.display = "none";

        displayFlexAntibiotico = false;
        document.getElementById("filAntibiotico").style.display = "none";

        displayFlexGramPositiva = false;
        document.getElementById("filGramPositiva").style.display = "none";

        displayFlexMorfologia = false;
        document.getElementById("filMorfologia").style.display = "none";
    }
    else {
        document.getElementById("filGramNegativa").style.display = "none";
        displayFlexGramNegativa = false;
    }

}

/*função para mostrar filtros: Morfologia*/
var displayFlexMorfologia = false;
function mostrarMorfologia() {

    if (displayFlexMorfologia == false) {
        document.getElementById("filMorfologia").style.display = "flex";
        displayFlexMorfologia = true;

        displayFlexNome = false;
        document.getElementById("filNome").style.display = "none";

        displayFlexAntibiotico = false;
        document.getElementById("filAntibiotico").style.display = "none";

        displayFlexGramPositiva = false;
        document.getElementById("filGramPositiva").style.display = "none";

        displayFlexGramNegativa = false;
        document.getElementById("filGramNegativa").style.display = "none";
    }
    else {
        document.getElementById("filMorfologia").style.display = "none";
        displayFlexMorfologia = false;
    }
}

function gerarTabelaAntibioticos(dados) {
    const tbody = document.getElementById("tabela");
    if (!tbody) {
        console.error(`Elemento com id "${"tabela"}" não encontrado.`);
        return;
    }

    // Limpa o conteúdo anterior do tbody
    tbody.innerHTML = '';

    if (dados.length === 0) {
        const linha = document.createElement('tr');
        linha.innerHTML = `<td colspan="6">Nenhum registro encontrado</td>`;
        tbody.appendChild(linha);
        return;
    }

    dados.forEach((item, index) => {
        const linha = document.createElement('tr');

        linha.innerHTML = `
        <td>${item.nome}</td>
        <td>${item.tipo_antibiotico}</td>
        <td>${item.gram_positiva}</td>
        <td>${item.gram_negativa}</td>
        <td>${item.morfologia}</td>
      `;

        tbody.appendChild(linha);
    });
}

function filtrarAZ(antibioticosLista, param) {

    return antibioticosLista.sort((a, b) => {
        if (a[param] < b[param]) {
            return -1;  // A vem antes de B
        }
        if (a[param] > b[param]) {
            return 1;   // B vem antes de A
        }
        return 0;  // A e B são iguais
    });
}

function clickAZNome(antibioticosLista) {
    filtrarAZ(antibioticosLista, 'nome');
    gerarTabelaAntibioticos(antibioticosLista);
}

function filtrarZA(antibioticosLista, param) {

    return antibioticosLista.sort((a, b) => {
        if (a[param] > b[param]) {
            return -1;  // A vem antes de B
        }
        if (a[param] < b[param]) {
            return 1;   // A vem antes de B
        }
        return 0;  // A e B são iguais
    });
}

function clickZANome(antibioticosLista) {
    filtrarZA(antibioticosLista, 'nome');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickAZGramPositiva(antibioticosLista) {
    filtrarAZ(antibioticosLista, 'gram_positiva');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickZAGramPositiva(antibioticosLista) {
    filtrarZA(antibioticosLista, 'gram_positiva');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickAZGramNegativa(antibioticosLista) {
    filtrarAZ(antibioticosLista, 'gram_negativa');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickZAGramNegativa(antibioticosLista) {
    filtrarZA(antibioticosLista, 'gram_negativa');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickAZMorfologia(antibioticosLista) {
    filtrarAZ(antibioticosLista, 'morfologia');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickZAMorfologia(antibioticosLista) {
    filtrarZA(antibioticosLista, 'morfologia');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickAZTipoAntibiotico(antibioticosLista) {
    filtrarAZ(antibioticosLista, 'tipo_antibiotico');
    gerarTabelaAntibioticos(antibioticosLista);
}

function clickZATipoAntibiotico(antibioticosLista) {
    filtrarZA(antibioticosLista, 'tipo_antibiotico');
    gerarTabelaAntibioticos(antibioticosLista);
}

function limparFiltro(formId) {
    const form = document.getElementById(formId);
    if (form) {
        form.querySelectorAll("input[type=checkbox]").forEach(checkbox => {
            checkbox.checked = true;
        });
    }
}

function limparOrdem(antibioticosListaOriginal, antibioticosLista) {
    aplicaFiltroCheckboxes(antibioticosLista, antibioticosListaOriginal);
    gerarTabelaAntibioticos(antibioticosLista);

    return antibioticosLista; // opcional, já que o array original foi modificado
}

function pesquisarNome(antibioticosLista, texto) {

    const valorTexto = texto.toLowerCase().trim();

    return antibioticosLista.filter(item =>
        item.nome.toLowerCase().startsWith(valorTexto)
    );
}

function filtrarNomeInput(antibioticosLista, antibioticosListaOriginal) {
    const input = document.getElementById("pesquisarNome");
    const texto = input.value;

    const filtrado = Array.from(pesquisarNome(antibioticosLista, texto));

    if (antibioticosLista.length > 0) {
        // Clear the original array
        antibioticosLista.splice(0, antibioticosLista.length, ...filtrado);

        console.log(filtrado);
        gerarTabelaAntibioticos(antibioticosLista);
    }
}


function aplicaFiltroCheckboxes(antibioticosLista, listaOriginal) {
    antibioticosLista.splice(0, antibioticosLista.length);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.MACROLIDEOS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.PENICILINAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.CEFALOSPORINAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.CARBAPENEMICOS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.AMINOGLICOSIDEOS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.QUINOLONAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.ANFENICOIS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.SULFONAMIDAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.GLICOPEPTIDEOS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.NITROIMIDAZOLICOS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.LICOSAMIDAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.POLIMIXINAS);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.OXAZOLIDINONA);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.GLICILCICLINA);
    aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, TipoAntibiotico.ANTITUBERCULOSOS);
    aplicarFiltroCheckboxGramPositiva(antibioticosLista, "✅", checkGramPositivaYesId);
    aplicarFiltroCheckboxGramPositiva(antibioticosLista, "❌", checkGramPositivaNoId);
    aplicarFiltroCheckboxGramNegativa(antibioticosLista, "✅", checkGramNegativaYesId);
    aplicarFiltroCheckboxGramNegativa(antibioticosLista, "❌", checkGramNegativaNoId);
    filtraMorfologia(antibioticosLista, "Cocos", checkCoccosId);
    filtraMorfologia(antibioticosLista, "Bacilos", checkBacilosId);
    filtraMorfologia(antibioticosLista, "Cocos e Bacilos", checkCoccosBacilosId);
    filtrarNomeInput(antibioticosLista, listaOriginal);
}

function adicionarAntibioticosDoTipo(antibioticosLista, tipo, listaOriginal) {
    const antibioticosDoTipo = listaOriginal.filter(item => item.tipo_antibiotico === tipo);
    //console.log("Adicionando antibióticos do tipo:", tipo, antibioticosDoTipo);
    //console.log("antibioticos adiocionando: ", antibioticosDoTipo);
    antibioticosLista.push(...antibioticosDoTipo);
}

function aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, tipoAFiltrar) {
    let checked = document.getElementById(checkBoxFiltroComecoId + tipoAFiltrar).checked;

    // Coleta os índices dos elementos a serem removidos
    const indicesParaRemover = [];
    antibioticosLista.forEach((element, idx) => {
        if (element.tipo_antibiotico == tipoAFiltrar && !checked) {
            indicesParaRemover.push(idx);
            console.log("Removendo ", element.nome);
        }
    });

    // Remove do fim para o começo para não bagunçar os índices
    for (let i = indicesParaRemover.length - 1; i >= 0; i--) {
        antibioticosLista.splice(indicesParaRemover[i], 1);
    }

    if (checked) {
        adicionarAntibioticosDoTipo(antibioticosLista, tipoAFiltrar, listaOriginal);
    }
}


function aplicarFiltroCheckboxGramPositiva(antibioticosLista, positivoAtaca, idCheckBox) {
    let checked = document.getElementById(idCheckBox).checked;

    // Coleta os índices dos elementos a serem removidos
    const indicesParaRemover = [];
    antibioticosLista.forEach((element, idx) => {
        if (element.gram_positiva == positivoAtaca && !checked) {
            indicesParaRemover.push(idx);
            console.log("Removendo ", element.nome);
        }
    });

    // Remove do fim para o começo para não bagunçar os índices
    for (let i = indicesParaRemover.length - 1; i >= 0; i--) {
        antibioticosLista.splice(indicesParaRemover[i], 1);
    }
}

function aplicarFiltroCheckboxGramNegativa(antibioticosLista, negativoAtaca, idCheckBox) {
    let checked = document.getElementById(idCheckBox).checked;

    // Coleta os índices dos elementos a serem removidos
    const indicesParaRemover = [];
    antibioticosLista.forEach((element, idx) => {
        if (element.gram_negativa == negativoAtaca && !checked) {
            indicesParaRemover.push(idx);
            console.log("Removendo ", element.nome);
        }
    });

    // Remove do fim para o começo para não bagunçar os índices
    for (let i = indicesParaRemover.length - 1; i >= 0; i--) {
        antibioticosLista.splice(indicesParaRemover[i], 1);
    }
}

function okApply(antibioticosLista, antibioticosListaOriginal) {
    aplicaFiltroCheckboxes(antibioticosLista, antibioticosListaOriginal);
    gerarTabelaAntibioticos(antibioticosLista);
}

function okClickedTipo(antibioticosLista, antibioticosListaOriginal) {
    okApply(antibioticosLista, antibioticosListaOriginal);
    mostrarFiltrosAntibiotico();
}

function okClickedGramPositiva(antibioticosLista, antibioticosListaOriginal) {
    okApply(antibioticosLista, antibioticosListaOriginal);
    mostrarGramPositiva();
}

function okClickedGramNegativa(antibioticosLista, antibioticosListaOriginal) {
    okApply(antibioticosLista, antibioticosListaOriginal);
    mostrarGramNegativa();
}

function okClickedMorfologia(antibioticosLista, antibioticosListaOriginal) {
    okApply(antibioticosLista, antibioticosListaOriginal);
    mostrarMorfologia();
}

function resetarCheckedCancel(antibioticosLista) {
    // Reseta o checked de acordo com o que tem na tabela atual
    antibioticosLista.forEach(element => {
        let checkbox = document.getElementById(checkBoxFiltroComecoId + element.tipo_antibiotico);
        checkbox.checked = true;
    });

    // Verifica se há algum gram positiva/negativa marcado com ✅ ou ❌
    const gramPositivaYes = document.getElementById(checkGramPositivaYesId);
    const gramPositivaNo = document.getElementById(checkGramPositivaNoId);
    const gramNegativaYes = document.getElementById(checkGramNegativaYesId);
    const gramNegativaNo = document.getElementById(checkGramNegativaNoId);

    const hasGramPositivaMarkedYes = antibioticosLista.some(item => item.gram_positiva === "✅");
    const hasGramPositivaMarkedNo = antibioticosLista.some(item => item.gram_positiva === "❌");
    const hasGramNegativaMarkedYes = antibioticosLista.some(item => item.gram_negativa === "✅");
    const hasGramNegativaMarkedNo = antibioticosLista.some(item => item.gram_negativa === "❌");

    // Marca ou desmarca os checkboxes de gram positiva/negativa
    if (hasGramPositivaMarkedYes) {
        gramPositivaYes.checked = true;
    }

    if (hasGramPositivaMarkedNo)
    {
        gramPositivaNo.checked = true;
    }
    
    if (hasGramNegativaMarkedYes)
    {
        gramNegativaYes.checked = true;
    }

    if (hasGramNegativaMarkedNo)
    {
        gramNegativaNo.checked = true;
    }

    // Verifica se há algum morfologia marcado com os tipos específicos
    const morfologiaCocos = document.getElementById(checkCoccosId);
    const morfologiaBacilos = document.getElementById(checkBacilosId);
    const morfologiaCocosBacilos = document.getElementById(checkCoccosBacilosId);

    const hasMorfologiaCocos = antibioticosLista.some(item => item.morfologia === "Cocos");
    const hasMorfologiaBacilos = antibioticosLista.some(item => item.morfologia === "Bacilos");
    const hasMorfologiaCocosBacilos = antibioticosLista.some(item => item.morfologia === "Cocos e Bacilos");

    // Marca ou desmarca os checkboxes de morfologia
    if (hasMorfologiaCocos) {
        morfologiaCocos.checked = true;
    }

    if (hasMorfologiaBacilos) {
        morfologiaBacilos.checked = true;
    }

    if (hasMorfologiaCocosBacilos) {
        morfologiaCocosBacilos.checked = true;
    }

}

function filtraMorfologia(listaAntibioticos, tipo, idCheckBox) {
    // Coleta os índices dos elementos a serem removidos
    const indicesParaRemover = [];
    const checked = document.getElementById(idCheckBox).checked;
    listaAntibioticos.forEach((element, idx) => {
        if (element.morfologia == tipo && !checked) {
            indicesParaRemover.push(idx);
            console.log("Removendo ", element.nome);
        }
    });

    // Remove do fim para o começo para não bagunçar os índices
    for (let i = indicesParaRemover.length - 1; i >= 0; i--) {
        listaAntibioticos.splice(indicesParaRemover[i], 1);
    }
}

function selecionarTodos(divId, selecionarTodosId) {
    // Encontra a div pelo ID
    const div = document.getElementById(divId);
    
    // Se a div existir, encontra todos os checkboxes dentro dela
    if (div) {
        const checkboxes = div.querySelectorAll('input[type="checkbox"]');
        
        // Marca todos os checkboxes como checked
        checkboxes.forEach(checkbox => {
            checkbox.checked = document.getElementById(selecionarTodosId).checked;
        });
    }
}

function cancelarClickedTipo(antibioticosLista)
{
    resetarCheckedCancel(antibioticosLista);
    mostrarFiltrosAntibiotico();
}

function cancelarClickedGramPositiva(antibioticosLista)
{
    resetarCheckedCancel(antibioticosLista);
    mostrarGramPositiva();
}

function cancelarClickedGramNegativa(antibioticosLista)
{
    resetarCheckedCancel(antibioticosLista);
    mostrarGramNegativa();
}

function cancelarClickMorfologia(antibioticosLista)
{
    resetarCheckedCancel(antibioticosLista);
    mostrarMorfologia();
}