(() => {
        'use strict';
        
        const form = document.querySelector('.needs-validation');
        
        form.addEventListener('submit', event => {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            } else {
                event.preventDefault(); // Previna o envio padrão para permitir o redirecionamento
                window.location.href = "index.html";
            }
            form.classList.add('was-validated');
        }, false);
    })();
    