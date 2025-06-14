function validation() {

    // Variavel de validação para enivar o formulario caso a validação esteja correta
    var validationCheck = 0;

    // Validação email
    var email = document.getElementById("email").value;
    if(!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
        document.getElementById("valEmail").style.display = "flex";
        document.getElementById("email").style.marginBottom = "0";
    }
    else {
        document.getElementById("valEmail").style.display = "none";
        document.getElementById("email").style.marginBottom = "20px";
        validationCheck++;
    }

    // Validação mensagem
    var mensagem = document.getElementById("mensagem").value;
    if(mensagem.trim() === "") {
        document.getElementById("valMensagem").style.display = "flex";
        document.getElementById("mensagem").style.marginBottom = "0";
    }
    else {
        document.getElementById("valMensagem").style.display = "none";
        document.getElementById("mensagem").style.marginBottom = "20px";
        validationCheck++;
    }

    // Envio da mensagem do usuario ao enviar o formulario de maneira correta
    if(validationCheck == 2) {
        document.getElementById('form-contato').submit();
    }

}