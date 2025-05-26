document.getElementById('telefone').addEventListener('input', function (e) {
    let x = e.target.value.replace(/\D/g, '').match(/(\d{0,2})(\d{0,5})(\d{0,4})/);
    e.target.value = !x[2] ? x[1] : '(' + x[1] + ') ' + x[2] + (x[3] ? '-' + x[3] : '');
});


// Transferindo as informações do formulario para o php
const formCadUsuario = document.getElementById("form-cad-usuario");
if(formCadUsuario) {
    formCadUsuario.addEventListener("submit", async(e) => {
        e.preventDefault(); // Impede o recarregamento da pagina
        // Receber os dados do formulario
        const dadosForm = new FormData(formCadUsuario);

        // Transfere os dados do js para o php através do método POST, para no arquivo "cadastro.php" salvar no BD
        const dados = await fetch("cadastro.php", {
            method: "POST",
            body: dadosForm
        });
    });
}