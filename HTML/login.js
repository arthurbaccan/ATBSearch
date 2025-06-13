function validation() {

    // Variavel de validação para pesquisaer o usuario no banco de dados caso a validação esteja correta
    var validationCheck = 0;

    // Validação email ou telefone 
    var emailOrPhone = document.getElementById("emailOrPhone").value;
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(emailOrPhone)) {
        if (!/^\d{11}$/.test(emailOrPhone)) {
            document.getElementById("valEmailorPhone").style.display = "flex";
            document.getElementById("emailOrPhone").style.borderColor = "red";
        }
        else {
            document.getElementById("valEmailorPhone").style.display = "none";
            document.getElementById("emailOrPhone").style.borderColor = "black";
            validationCheck++;
        }
    }
    else {
        document.getElementById("valEmailorPhone").style.display = "none";
        document.getElementById("emailOrPhone").style.borderColor = "black";
        validationCheck++;
    }

    // Validação senha
    var senha = document.getElementById("senha").value;
    if (senha.length < 6) {
        document.getElementById("valSenha").style.display = "flex";
        document.getElementById("senha").style.borderColor = "red";
    }
    else {
        document.getElementById("valSenha").style.display = "none";
        document.getElementById("senha").style.borderColor = "black";
        validationCheck++;
    }

    // Cadastro do usuario ao enviar o formulario de maneira correta
    if(validationCheck == 2) {
        document.getElementById('form-log-usuario').submit();
        window.location.href = "index.html";
    }
}