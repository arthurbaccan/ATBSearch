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

const windowWidth = window.innerWidth;
const windowHeight = window.innerHeight;

const logo = document.querySelectorAll(".logo");

logo.forEach(logo => {
    logo.style.fontSize = (2*(windowWidth/100) + (windowWidth/200)) + "px";
    

})


