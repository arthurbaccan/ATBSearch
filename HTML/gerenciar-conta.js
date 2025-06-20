function logout() {
    window.location.href = "logout.php";
}

function trocarConta() {
  Swal.fire({
    title: 'Trocar Conta',
    html:
      '<input id="swal-input1" class="swal2-input" placeholder="Email ou telefone">' +
      '<input id="swal-input2" class="swal2-input" placeholder="Senha" type="password">',
    focusConfirm: false,
    showCancelButton: true,
    confirmButtonText: 'Enviar',
    cancelButtonText: 'Cancelar',
    preConfirm: () => {
      const email = document.getElementById('swal-input1').value;
      const senha = document.getElementById('swal-input2').value;

      if (!email || !senha) {
        Swal.showValidationMessage('Por favor, preencha os dois campos');
        return false;
      }

      return { email, senha };
    }
  }).then((result) => {
    if (result.isConfirmed) {
      console.log('Email:', result.value.email);
      console.log('Senha:', result.value.senha);
    }
  });
}

function mudarNome() {
    Swal.fire({
        title: 'Alterar nome',
        input: 'text',
        inputPlaceholder: 'Novo nome',
        showCancelButton: true,
        confirmButtonText: 'Enviar',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            enviarParaCookie('nome', result.value);
        }
    });
}

function mudarSenha() {
  Swal.fire({
    title: 'Alterar senha',
    html: `
      <input id="novaSenha" type="password" class="swal2-input" placeholder="Nova senha">
      <input id="senhaAtual" type="password" class="swal2-input" placeholder="Senha atual">
    `,
    focusConfirm: false,
    showCancelButton: true,
    confirmButtonText: 'Enviar',
    cancelButtonText: 'Cancelar',
    preConfirm: () => {
      const novaSenha = document.getElementById('novaSenha').value.trim();
      const senhaAtual = document.getElementById('senhaAtual').value.trim();

      if (!novaSenha || !senhaAtual) {
        Swal.showValidationMessage('Preencha os dois campos.');
        return false;
      }

      return { novaSenha, senhaAtual };
    }
  }).then((result) => {
    if (result.isConfirmed) {
      console.log("Nova senha:", result.value.novaSenha);
      console.log("Senha atual:", result.value.senhaAtual);
    }
  });
}

function mudarTelefone() {
    Swal.fire({
        title: 'Alterar telefone',
        input: 'number',
        inputPlaceholder: 'Novo telefone',
        showCancelButton: true,
        confirmButtonText: 'Enviar',
        cancelButtonText: 'Cancelar'
    }).then((result) => {
        if (result.isConfirmed) {
            enviarParaCookie('telefone', result.value);
        }
    });
}