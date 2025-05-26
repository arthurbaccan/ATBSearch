document.getElementById('telefone').addEventListener('input', function (e) {
    let x = e.target.value.replace(/\D/g, '').match(/(\d{0,2})(\d{0,5})(\d{0,4})/);
    e.target.value = !x[2] ? x[1] : '(' + x[1] + ') ' + x[2] + (x[3] ? '-' + x[3] : '');
});

var validado = false;
if (validado == true) {
    
}

var focusNome = false;
function teste() {
    if(focusNome == true) {
        
    }
}

var certo1 = false;
var certo2 = false;
var certo3 = false;

function validar()  {
    var nome = document.getElementById("nome").value;
    var email = document.getElementById("email").value;
    var senha = document.getElementById("senha").value;

    if(nome === "") {
        document.getElementById("valNome").textContent = "Por favor, preencha este campo";
        document.getElementById("valNome").style.color = "red";
        document.getElementById("valNome").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
        document.getElementById("valNome").style.fontSize = "13px";

        document.getElementById("nome").style.border = "2px solid red";
        document.getElementById("nome").style.outline = "0px";
    }
    else {
        if(nome.length <3) {
            document.getElementById("valNome").textContent = "O nome deve ter ao menos 3 caracteres";
            document.getElementById("valNome").style.color = "red";
            document.getElementById("valNome").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
            document.getElementById("valNome").style.fontSize = "13px";

            document.getElementById("nome").style.border = "2px solid red";
            document.getElementById("nome").style.outline = "0px";
        }
        else{
            document.getElementById("valNome").textContent = "";
            document.getElementById("nome").style.border = "2px solid black";
            document.getElementById("nome").style.outline = "0px";

            certo1 = true;
        }
    }

    if(email === "") {
        document.getElementById("valEmail").textContent = "Por favor, preencha este campo";
        document.getElementById("valEmail").style.color = "red";
        document.getElementById("valEmail").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
        document.getElementById("valEmail").style.fontSize = "13px";

        document.getElementById("email").style.borderColor = "red";
        document.getElementById("email").style.outline = "0px";
    }
    else {
        const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if(regex.test(email)) {
            document.getElementById("valEmail").textContent = "";
            document.getElementById("email").style.border = "2px solid black";
            document.getElementById("email").style.outline = "0px";

            certo2 = true;
        }
        else {
            document.getElementById("valEmail").textContent = "Preencha este campo corretamente";
            document.getElementById("valEmail").style.color = "red";
            document.getElementById("valEmail").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
            document.getElementById("valEmail").style.fontSize = "13px";

            document.getElementById("email").style.borderColor = "red";
            document.getElementById("email").style.outline = "0px";
        }
    }

    if(senha === "") {
        document.getElementById("valSenha").textContent = "Por favor, preencha este campo";
        document.getElementById("valSenha").style.color = "red";
        document.getElementById("valSenha").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
        document.getElementById("valSenha").style.fontSize = "13px";

        document.getElementById("senha").style.border = "2px solid red";
        document.getElementById("senha").style.outline = "0px";
    }
    else {
        if(senha.length <8) {
            document.getElementById("valSenha").textContent = "A senha deve ter ao menos 8 caracteres";
            document.getElementById("valSenha").style.color = "red";
            document.getElementById("valSenha").style.fontFamily = "'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif";
            document.getElementById("valSenha").style.fontSize = "13px";

            document.getElementById("senha").style.border = "2px solid red";
            document.getElementById("senha").style.outline = "0px";
        }
        else{
            document.getElementById("valSenha").textContent = "";
            document.getElementById("senha").style.border = "2px solid black";
            document.getElementById("senha").style.outline = "0px";

            certo3 = true;
        }
    }
    if (certo1 == true &&
        certo2 == true &&
        certo3 == true
    ) {
        //Deixa os dados no formato de formulario HTML
        let dados = `nome=${encodeURIComponent(nome)}&email=${encodeURIComponent(email)}&senha=${encodeURIComponent(senha)}`;

        // Envia via POST para o PHP
        fetch("cadastro.php", {
            method: "POST",
            headers: {
                "Content-Type": "application/x-www-form-urlencoded"//faz um submit dos dados do formulario para o php
            },
            body: dados
        })
        .then(response => response.json()) // Espera resposta JSON do PHP
        .then(data => {
            console.log(data.mensagem); // Exibe a mensagem recebida do PHP
        })
        .catch(error => {
            console.error("Erro ao enviar:", error);
        });
    }
}