<?php
// Apaga o cookie do usuário
setcookie('usuarios', '', time() - 3600, "/");

// Redireciona para a página inicial ou login
header("Location: index.php");
exit;
?>