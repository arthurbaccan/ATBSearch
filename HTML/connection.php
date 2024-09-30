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
$db = 'Antibioticos';
$user = 'cl203219';
$pass = 'cl*25052007';

try {
    $pdo = new PDO("mysql:host=$host;dbname=$db", $user, $pass);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    echo 'Conexão falhou: ' . $e->getMessage();
}

?>