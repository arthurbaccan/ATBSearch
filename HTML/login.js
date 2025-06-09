function validation() {

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
        }
    }
    else {
        document.getElementById("valEmailorPhone").style.display = "none";
        document.getElementById("emailOrPhone").style.borderColor = "black";
    }

}