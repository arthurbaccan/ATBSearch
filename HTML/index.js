//usar junto com o fixed do css na barra de pesquisa da tabela
document.addEventListener('scroll', function() {
    var barra = document.querySelector('.');
    var offset = barra.offsetTop;
    
    if (window.scrollY > offset) {
        barra.classList.add('fixed');
    } else {
        barra.classList.remove('fixed');
    }
});

//muda os tamnhos da ogo para deixar responsivo
function updateWidth() {
    const windowWidth = window.innerWidth;
    const windowHeight = window.innerHeight;

    const logo = document.querySelectorAll(".logo");
    const imagemLogo = document.querySelectorAll(".imagem-logo");

    if(innerWidth >= innerHeight) {
        logo.forEach(logo => {
            logo.style.fontSize = (7*(windowWidth/200)) + "px";
            logo.style.padding = (windowWidth/100) + "px";

    
        })

        imagemLogo.forEach(imagemLogo => {
            imagemLogo.style.width = (4*(windowWidth/95)) + "px";
        })
    }
    else {
        
    }
}

//sempre chama a função de responsividade quando o site é iniciado
updateWidth();

//torna a tela responsiva quando é redimensionada
window.addEventListener('resize', updateWidth);