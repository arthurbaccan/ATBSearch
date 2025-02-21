const toastTrigger = document.getElementById('liveToastBtn')
const toastLiveExample = document.getElementById('liveToast')

if (toastTrigger) {
  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
  toastTrigger.addEventListener('click', () => {
    toastBootstrap.show()
  })
}


/*Função para quberar palavras caso elas possuam mais de 12 caracteres*/ 
document.addEventListener('DOMContentLoaded', function() {
  const btn = document.querySelector('button.table-open');
  btn.innerHTML = btn.innerHTML.split(' ').map(word => {
    if(word.length > 12) {
      return word.replace(/(.{12})/g, '$1<wbr>');
    }
    return word;
  }).join(' ');
});
