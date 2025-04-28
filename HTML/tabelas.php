<?php

include 'antibiotico-repository.php';
// Parâmetros de conexão com o banco de dados
$host = '143.106.241.4';
$db = 'cl203248';
$user = 'cl203248';
$pass = 'cl*07062008';
$port = '3306';

$conn = new mysqli($host, $user, $pass, $db, $port);

// Verifica se houve erro na conexão
if ($conn->connect_error) {
    die("Conexão falhou: " . $conn->connect_error);
}

// Consulta SQL para obter os dados
$sql = "SELECT id, nome, tipo_antibiotico, gram_positiva, gram_negativa, morfologia FROM Antibiotico";
$resultado = $conn->query($sql);

// Se houver resultados, percorre cada linha e imprime uma linha da tabela
if ($resultado->num_rows > 0) {
    while($linha = $resultado->fetch_assoc()){
        echo "<tr>";
        echo "<td><input type='checkbox' id='cod' value=" . $linha['id'] . "></td>";
        echo "<td>" . $linha['nome'] . "</td>";
        echo "<td>" . transforamTipoEmString($linha['tipo_antibiotico']) . "</td>";
        echo "<td>" . transformaGramEmString($linha['gram_positiva']) . "</td>";
        echo "<td>" . transformaGramEmString($linha['gram_negativa']) . "</td>";
        echo "<td>" . transformaMorfologiaEmString($linha['morfologia']) . "</td>";
        echo "</tr>";
    }
} else {
    // Caso não haja registros, exibe uma linha informando que não há dados
    echo "<tr><td colspan='5'>Nenhum registro encontrado</td></tr>";
}

// Fecha a conexão com o banco de dados
$conn->close();
?>