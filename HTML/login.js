function validation() {

    // Validação email ou telefone 
    var emailOrPhone = document.getElementById("emailOrPhone").value;
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(emailOrPhone)) {
        if (emailOrPhone.trim() === "" ||
            emailOrPhone.trim() !== emailOrPhone |
            emailOrPhone.length != 11
            ) {
                document.getElementById("valEmailorPhone").style.display = "flex";
                document.getElementById("emailOrPhone").style.borderColor = "red";
        }
    }

}