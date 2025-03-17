const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
  toastTrigger.addEventListener('click', () => {
    toastBootstrap.show()
  })
}


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

/*Função pra pegar os dados do bd e colocar na tabela*/
document.addEventListener("DOMContentLoaded", () => {
  fetch("get_data.php")
      .then(response => response.json())
      .then(data => {
          let tableBody = document.getElementById("tabela-body");
          tableBody.innerHTML = "";

          data.forEach(item => {
              let row = `<tr>
                  <td>${item.nome}</td>
                  <td>${item.tipo_antibiotico}</td>
                  <td>${item.gram_positiva}</td>
                  <td>${item.gram_negativa}</td>
                  <td>${item.morfologia}</td>
              </tr>`;
              tableBody.innerHTML += row;
          });
      })
      .catch(error => console.error("Erro ao buscar dados:", error));
}); 