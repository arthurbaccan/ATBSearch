<?php
// Recupera a lista de todos os usuários
$usuarios = [];
if (isset($_COOKIE['usuarios'])) {
    $usuarios = json_decode($_COOKIE['usuarios'], true);
}

// Processa apenas POST
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $entrada = trim($_POST['emailOrPhone']);
    $senha   = trim($_POST['senha']);

    $usuarioEncontrado = null;
    foreach ($usuarios as $u) {
    $telSalvo = preg_replace('/\D/', '', $u['telefone']);
    $entLimpa = preg_replace('/\D/', '', $entrada);

    $isEmailMatch = $u['email'] === $entrada;
    $isPhoneMatch = $telSalvo === $entLimpa;

    if ($isEmailMatch || $isPhoneMatch) {
        if ($u['senha'] === sha1($senha)) {
            $usuarioEncontrado = $u;
            break;
        }
    }
}

    if ($usuarioEncontrado) {
        // Recria o cookie de sessão do usuário
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

// Falha no login
header("Location: login.php?erro=1");
exit;
?>