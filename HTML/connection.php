<!-- Futuramente eu vou usar isso daqui pra fazer o back-end, mas eu preciso da uma estudada de php e javascript, nao da pra fazer as tabelas sem essa merda -->

<!-- Tem que lembrar no futuro que não vai ser um monte de String, vai ser String só pra nome, o restante vão ter numeros atribuídos e vão ter switchs,
Ex: Tipo da bacteria
case (1): Gram positiva
case (2): Gram negativa
case (3): gram positiva e negativa

Os nomes vão ser var pq eles sempre são diferentes, já vão funcionar como "id" da nossa tabela
Tipos de antibioticos vão ser a mesma coisa do tipo de bacteria, só que com mais casos
Morfologia é igual o tipo de bacteria, 3 casos e dependendo do numero que ta no banco, vai retornar uma mensagem diferente

As tabelas personalizadas não rodam sem isso aqui, , então vou ter que atrbuir ao modelo defalt de tabelas os valores que precisar
-->

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

$sql = "SELECT id, nome, tipo_antibiotico, gram_positiva, gram_negativa, morfologia FROM Antibiotico;";
$result = $conn->query($sql);

$dados = [];
while ($row = $result->fetch_assoc()) {
    $dados[] = $row;
}

echo json_encode($dados);
$conn->close();
?>