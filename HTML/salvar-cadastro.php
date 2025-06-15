<?php
// Pega os usuários já salvos no cookie, se houver
$usuarios = [];
if (isset($_COOKIE['usuarios'])) {
    $usuarios = json_decode($_COOKIE['usuarios'], true);
}

// Verifica se o formulário foi enviado
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $nome = trim($_POST['nome']);
    $email = trim($_POST['email']);
    $senha = trim($_POST['senha']);
    $telefone = isset($_POST['telefone']) ? preg_replace('/\D/', '', $_POST['telefone']) : "";

    if ($nome !== "" && $email !== "" && $senha !== "") {
        $usuario = [
            'nome' => $nome,
            'email' => $email,
            'senha' => $senha,
            'telefone' => $telefone
        ];

        // Adiciona o novo usuário ao array existente
        $usuarios[] = $usuario;

        // Salva o novo array completo no cookie
        setcookie('usuarios', json_encode($usuarios), time() + (86400 * 7), "/");

        // Também salva o usuário logado separadamente
        setcookie('usuario', json_encode($usuario), time() + (86400 * 7), "/");

        header("Location: index.php");
        exit;
    } else {
        header("Location: cadastro.php");
    }
}
?>