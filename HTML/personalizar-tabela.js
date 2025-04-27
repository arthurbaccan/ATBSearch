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

/*função para filtrar pelo nome*/
var displayFlexNome = false;
function mostrarFiltrosNome() {

    if(displayFlexNome == false) {
        document.getElementById("filNome").style.display = "flex";
        displayFlexNome = true;
    }
    else {
        document.getElementById("filNome").style.display = "none";
        displayFlexNome = false;
    }

}

var displayFlexAntibiotico = false;
function mostrarFiltrosAntibiotico() {

    if(displayFlexAntibiotico == false) {
        document.getElementById("filAntibiotico").style.display = "flex";
        displayFlexAntibiotico = true;
    }
    else {
        document.getElementById("filAntibiotico").style.display = "none";
        displayFlexAntibiotico = false;
    }

}