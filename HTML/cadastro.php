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


?>