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

function filtrarNomeAZ(antibioticosLista) {

    return antibioticosLista.sort((a, b) => {
        if (a.nome < b.nome) {
            return -1;  // A vem antes de B
        }
        if (a.nome > b.nome) {
            return 1;   // B vem antes de A
        }
        return 0;  // A e B são iguais
    });
}

function clickAZNome(antibioticosLista) {
    filtrarNomeAZ(antibioticosLista);
    gerarTabelaAntibioticos(antibioticosLista);
}

function filtrarNomeZA(antibioticosLista) {

    return antibioticosLista.sort((a, b) => {
        if (a.nome > b.nome) {
            return -1;  // A vem antes de B
        }
        if (a.nome < b.nome) {
            return 1;   // A vem antes de B
        }
        return 0;  // A e B são iguais
    });
}

function clickZANome(antibioticosLista) {
    filtrarNomeZA(antibioticosLista);
    gerarTabelaAntibioticos(antibioticosLista);
}

function limparOrdemNome(antibioticosListaOriginal, antibioticosLista) {
    antibioticosLista.splice(0, antibioticosLista.length);
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

    // Clear the original array
    antibioticosLista.splice(0, antibioticosLista.length, ...filtrado);

    if (antibioticosLista.length > 0) {
        aplicaFiltroCheckboxes(antibioticosLista, antibioticosListaOriginal);
        gerarTabelaAntibioticos(antibioticosLista);
    }
}


function aplicaFiltroCheckboxes(antibioticosLista, listaOriginal) {
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
}

function adicionarAntibioticosDoTipo(antibioticosLista, tipo, listaOriginal) {
    const antibioticosDoTipo = listaOriginal.filter(item => item.tipo_antibiotico === tipo);
    //console.log("Adicionando antibióticos do tipo:", tipo, antibioticosDoTipo);
    //console.log("antibioticos adiocionando: ", antibioticosDoTipo);
    antibioticosLista.push(...antibioticosDoTipo);
}

function aplicarFiltroCheckboxTipo(antibioticosLista, listaOriginal, tipoAFiltrar) {
    let checked = document.getElementById(checkBoxFiltroComecoId + tipoAFiltrar).checked

    antibioticosLista.forEach(element => {
            if (element.tipo_antibiotico == tipoAFiltrar) {
                if (!checked) {
                    antibioticosLista.splice(antibioticosLista.indexOf(element), 1)
                    console.log("Removendo ", element.nome);
                }
                
                //console.log(checked);
            }
    });

    if (checked) {
        adicionarAntibioticosDoTipo(antibioticosLista, tipoAFiltrar, listaOriginal);
    }
}


function macrolideosClicked() {
    let checked = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.MACROLIDEOS).checked
    console.log(checked);
}

function penicilinasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.PENICILINAS)
    console.log(checkbox.checked);
}

function cefalosporinasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.CEFALOSPORINAS);
    console.log(checkbox.checked);
}

function carbapenemicosClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.CARBAPENEMICOS);
    console.log(checkbox.checked);
}

function aminoglicosideosClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.AMINOGLICOSIDEOS);
    console.log(checkbox.checked);
}

function quinolonasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.QUINOLONAS);
    console.log(checkbox.checked);
}

function anfenicoisClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.ANFENICOIS);
    console.log(checkbox.checked);
}

function sulfonamidasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.SULFONAMIDAS);
    console.log(checkbox.checked);
}

function glicopeptideosClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.GLICOPEPTIDEOS);
    console.log(checkbox.checked);
}

function nitroimidazolicosClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.NITROIMIDAZOLICOS);
    console.log(checkbox.checked);
}

function licosamidasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.LICOSAMIDAS);
    console.log(checkbox.checked);
}

function polimixinasClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.POLIMIXINAS);
    console.log(checkbox.checked);
}

function oxazolidinonaClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.OXAZOLIDINONA);
    console.log(checkbox.checked);
}

function glicilciclinaClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.GLICILCICLINA);
    console.log(checkbox.checked);
}

function antituberculososClicked() {
    let checkbox = document.getElementById(checkBoxFiltroComecoId + TipoAntibiotico.ANTITUBERCULOSOS);
    console.log(checkbox.checked);
}

function okClicked(antibioticosLista, antibioticosListaOriginal) {
    aplicaFiltroCheckboxes(antibioticosLista, antibioticosListaOriginal);
    gerarTabelaAntibioticos(antibioticosLista);
}

function cancelarClicked(antibioticosLista)
{
    // reseta o checked de acordo com o que tem na tabela atual
    antibioticosLista.forEach(element => {
        let checkbox = document.getElementById(checkBoxFiltroComecoId + element.tipo_antibiotico);
        checkbox.checked = true;
    });
}