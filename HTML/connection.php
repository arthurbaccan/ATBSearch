<?php
$host = '143.106.241.4';
$db = 'cl203248';
$user = 'cl203248';
$pass = 'cl*07062008';
$port = '3306';

$conn = new mysqli($host, $user, $pass, $db, $port);
/*if($conn->connect_errno) {// Pode subtstituir connect_errno por connect_error number
    echo "Falha ao conectar: (" . $conn->connect_errno . ") " . $conn->connect_error;
}
else {
    echo "Conexão efetuada";
}*/
?>