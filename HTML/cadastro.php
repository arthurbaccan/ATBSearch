<?php
$host = '143.106.241.4';
$db = 'cl203248';
$user = 'cl203248';
$pass = 'cl*07062008';
$port = '3306';

$conn = new mysqli($host, $db, $user, $pass, $port);

if ($conn->connect_error) {
    die(json_encode(["error" => "Falha na conexão: " . $conn->connect_error]));
}

// Verifica se os dados estão vindo do POST
if (isset($_POST['nome']) && isset($_POST['email']) && isset($_POST['senha'])) {
    // Recebe os dados do formulário
    $nome = $_POST['nome'];
    $email = $_POST['email'];
    $senha = $_POST['senha'];

    // Você pode fazer a validação e processamento dos dados aqui
    // Por exemplo, verificar se o e-mail já está cadastrado, validar a senha, etc.

    // Para fins de exemplo, vamos apenas retornar uma mensagem de sucesso
    echo json_encode([
        'mensagem' => "Cadastro realizado com sucesso!",
        'nome' => $nome,
        'email' => $email
    ]);
} else {
    // Se faltar algum campo
    echo json_encode([
        'mensagem' => 'Erro: Dados incompletos.'
    ]);
}
?>