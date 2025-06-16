<?php
// 1) Recupera a lista de todos os usuários
$usuarios = [];
if (isset($_COOKIE['usuarios'])) {
    $usuarios = json_decode($_COOKIE['usuarios'], true);
}

// 2) Processa apenas POST
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $entrada = trim($_POST['emailOrPhone']);
    $senha   = trim($_POST['senha']);

    $usuarioEncontrado = null;
    foreach ($usuarios as $u) {
        // Normaliza números de telefone (só dígitos)
        $telSalvo = preg_replace('/\D/', '', $u['telefone']);
        $entLimpa = preg_replace('/\D/', '', $entrada);

        // Compara e‑mail ou telefone + senha
        if (
            ( $u['email'] === $entrada
              || $telSalvo    === $entLimpa )
            && $u['senha']  === $senha
        ) {
            $usuarioEncontrado = $u;
            break;
        }
    }

    if ($usuarioEncontrado) {
        // 3) Recria o cookie de sessão do usuário
        setcookie(
            'usuario',
            json_encode($usuarioEncontrado),
            time() + 86400 * 7,
            "/"
        );
        header("Location: index.php");
        exit;
    }
}

// Se chegou até aqui, falhou no login
header("Location: login.php?erro=1");
exit;
?>