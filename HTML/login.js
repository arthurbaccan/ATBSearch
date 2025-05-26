function validar() {
    var email = document.getElementById("email").value;

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
}