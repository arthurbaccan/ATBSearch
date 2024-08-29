//usar junto com o fixed do css na barra de pesquisa da tabela
/*document.addEventListener('scroll', function() {
    var barra = document.querySelector('.');
    var offset = barra.offsetTop;
    
    if (window.scrollY > offset) {
        barra.classList.add('fixed');
    } else {
        barra.classList.remove('fixed');
    }
});


function updateMediaQueries () {*/
    //Definição das media queries existentes
    /*const mediaQueries = [
        window.matchMedia('(min-width: 344px) and (max-width: 389px) and (min-height: 844px) and (max-height: 900px)'),
        window.matchMedia('(min-width: 390px) and (max-width: 430px) and (min-height: 850px) and (max-height: 950px)')
    ];*/

    //Recebe valor true se houver uma media query ativa
    /*let mediaQueryActive = false;

    //Verifica cada media query
    mediaQueries.forEach((query) => {
        if (query.matches) {
                mediaQueryActive = true;
        }
    });

    return mediaQueryActive;
}*/

//Função parar mudar os tamnhos da logo para fazer responsividade automatica
/*function updateWidth() {

    if(updateMediaQueries() == false) {
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
                imagemLogo.style.width = (windowWidth/6) + "px";
            })
        }
    }
}

function recarregarCSS() {
    const link = document.getElementById('teste-index');
    if (link) {
      link.href = link.href.split('?')[0] + '?v=' + new Date().getTime();
    }
}*/

//Sempre chama a função de responsividade quando o site é iniciado e não tenha uma media query ativa e torna a tela responsiva quando é redimensionada
/*document.addEventListener('DOMContentLoaded', function() {
    updateWidth();
    window.addEventListener('resize', updateWidth);
});*/