<?php
// Inicia o array de usuários
$usuarios = [];

// Verifica se o formulário foi enviado
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Dados do formulário
    $nome = trim($_POST['nome']);
    $email = trim($_POST['email']);
    $senha = trim($_POST['senha']);
    $telefone = isset($_POST['telefone']) ? $_POST['telefone'] : "";

    // Verifica se os campos obrigatórios foram preenchidos
    if ($nome !== "" && $email !== "" && $senha !== "") {
        // Remove máscara do telefone caso ele seja enviado
        $telefone = preg_replace('/\D/', '', $telefone);

        // Cria array do usuário
        $usuario = [
            'nome' => $nome,
            'email' => $email,
            'senha' => $senha,
            'telefone' => $telefone
        ];

        // Salva em array 
        $usuarios[] = $usuario;

        // Salva no cookie
        setcookie('usuarios', json_encode($usuarios), time() + (86400 * 7), "/"); // Dura 7 dias

        // Redireciona para a página inicial
        header("Location: index.php");
        exit;
    } else {
        header("Location: cadastro.php");
    }
}
?>