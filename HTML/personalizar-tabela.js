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

