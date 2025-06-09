document.getElementById('telefone').addEventListener('input', function (e) {
    let x = e.target.value.replace(/\D/g, '').match(/(\d{0,2})(\d{0,5})(\d{0,4})/);
    e.target.value = !x[2] ? x[1] : '(' + x[1] + ') ' + x[2] + (x[3] ? '-' + x[3] : '');
});

function validation() {

    // Variavel de validação para cadastrar o usuario no banco de dados caso a validação esteja correta
    var validationCheck = 0;

    // Validação nome
    var nome = document.getElementById("nome").value;
    if(nome.trim() === "" || nome.trim().length < 3) {
        document.getElementById("valNome").style.display = "flex";
        document.getElementById("nome").style.borderColor = "red";
    }
    else {
        document.getElementById("valNome").style.display = "none";
        document.getElementById("nome").style.borderColor = "black";
        validationCheck++;
    }

    // Validação email
    var email = document.getElementById("email").value;
    if(!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email)) {
        document.getElementById("valEmail").style.display = "flex";
        document.getElementById("email").style.borderColor = "red";
    }
    else {
        document.getElementById("valEmail").style.display = "none";
        document.getElementById("email").style.borderColor = "black";
        validationCheck++;
    }

    // Validação senha
    var senha = document.getElementById("senha").value;
    if(senha.trim() === "" || senha.trim().length < 6  || senha.trim() != senha) {
        document.getElementById("valSenha").style.display = "flex";
        document.getElementById("senha").style.borderColor = "red";
    }
    else {
        document.getElementById("valSenha").style.display = "none";
        document.getElementById("senha").style.borderColor = "black";
        validationCheck++;
    }

    // Validação telefone
    var telefone = document.getElementById("telefone").value;
    if(telefone.trim() !== "" && telefone.trim().length < 15) {
        document.getElementById("valTelefone").style.display = "flex";
        document.getElementById("telefone").style.borderColor = "red"
    }
    else {
        document.getElementById("valTelefone").style.display = "none";
        document.getElementById("telefone").style.borderColor = "black";
        validationCheck++;
    }

    // Cadastro do usuario ao enviar o formulario de maneira correta
    if(validationCheck == 4) {
        document.getElementById('form-cad-usuario').submit();
    }
}