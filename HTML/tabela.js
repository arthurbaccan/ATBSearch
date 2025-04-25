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



