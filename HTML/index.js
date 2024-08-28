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

//muda os tamnhos da logo para deixar responsivo
function updateWidth() {
    const windowWidth = window.innerWidth;
    const windowHeight = window.innerHeight;

    const logo = document.querySelectorAll(".logo");
    const imagemLogo = document.querySelectorAll(".imagem-logo");

    if(windowWidth >= windowHeight) {
        logo.forEach(logo => {
            logo.style.fontSize = ((windowWidth/23)) + "px";
            logo.style.paddingTop = (windowWidth/130) + "px";    
            logo.style.paddingBottom = (windowWidth/120) + "px";    
            logo.style.paddingLeft = 0 + "px";    

        })

        imagemLogo.forEach(imagemLogo => {
            imagemLogo.style.width = (4*(windowWidth/80)) + "px";
        })
    }
    else if(windowHeight > windowWidth) {
        logo.forEach(logo => {
            logo.style.fontSize = (3*(windowWidth/45)) + "px";
            logo.style.paddingTop = (windowWidth/50) + "px";    
            logo.style.paddingBottom = (windowWidth/50) + "px"; 
            logo.style.paddingLeft = ((windowWidth/12)) + "px"; 
            logo.style.gap = (windowWidth/18) + "px";
        })

        imagemLogo.forEach(imagemLogo => {
            imagemLogo.style.width = (windowWidth/5) + "px";
        })
    }
}

//sempre chama a função de responsividade quando o site é iniciado
updateWidth();

//torna a tela responsiva quando é redimensionada
window.addEventListener('resize', updateWidth);