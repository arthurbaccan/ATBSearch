/*Função para quebrar palavras dentro de um botão de classe table-open caso elas possuam mais de 12 caracteres*/ 
document.addEventListener('DOMContentLoaded', function() {
  const btn = document.querySelector('button.table-open');
  btn.innerHTML = btn.innerHTML.split(' ').map(word => {
    if(word.length > 12) {
      return word.replace(/(.{12})/g, '$1<wbr>');
    }
    return word;
  }).join(' ');
});

/*ao clicar no botão de adicionar tabela, redireciona para o site de criação de tabelas personalizadas*/
document.getElementById('add-table-button').addEventListener('click', function() {
  window.location.href = "personalizar-tabela.php"
});

/*Hover dos botões de acesso a uma tabela personalizada já pronta*/
var menuActiveVar = true;

function hoverDarkGreen() {
  document.getElementById("botao2").style.transition = "0.5s";
  document.getElementById("botao2").style.backgroundColor = "darkgreen";
}

function hoverDarkGreen2() {
  document.getElementById("botao2").style.backgroundColor = "green";
}

function hoverGray() {
  document.getElementById("botao2").style.transition = "0.5s";
  document.getElementById("botao2").style.backgroundColor = "#85a187";
  document.getElementById("botao2").style.borderRadius = "5px";
}

function hoverGray2() {
  document.getElementById("botao2").style.backgroundColor = "green";
}

// Ativa os eventos inicialmente
document.getElementById("botao1").addEventListener("mouseover", hoverDarkGreen);
document.getElementById("botao1").addEventListener("mouseleave", hoverDarkGreen2);
document.getElementById("botao2").addEventListener("mouseover", hoverGray);
document.getElementById("botao2").addEventListener("mouseleave", hoverGray2);

// Ao clicar no botão, desativa os eventos
menuActiveVar = false;
function menuActive() {

  if (menuActiveVar === false) {
    document.getElementById("botao1").removeEventListener("mouseover", hoverDarkGreen);
    document.getElementById("botao1").removeEventListener("mouseleave", hoverDarkGreen2);
    document.getElementById("botao2").removeEventListener("mouseover", hoverGray);
    document.getElementById("botao2").removeEventListener("mouseleave", hoverGray2);

    document.getElementById("botao2").style.transition = "0s"
    document.getElementById("botao2").style.borderBottomRightRadius = "0";
    document.getElementById("botao2").style.borderBottomLeftRadius = "0";
    document.getElementById("botao2").style.background = "#f4f4f9";
    document.getElementById("botao2").style.color = "black";

    document.getElementById("menu-button").style.display = "flex"

    menuActiveVar = true;
  }

  else {
    document.getElementById("botao1").addEventListener("mouseover", hoverDarkGreen);
    document.getElementById("botao1").addEventListener("mouseleave", hoverDarkGreen2);
    document.getElementById("botao2").addEventListener("mouseover", hoverGray);
    document.getElementById("botao2").addEventListener("mouseleave", hoverGray2);

    document.getElementById("botao2").style.transition = "0.5s"
    document.getElementById("botao2").style.borderBottomRightRadius = "5px";
    document.getElementById("botao2").style.borderBottomLeftRadius = "5px";
    document.getElementById("botao2").style.background = "#85a187";
    document.getElementById("botao2").style.color = "white";

    document.getElementById("menu-button").style.display = "none"

    menuActiveVar = false;
  }
}