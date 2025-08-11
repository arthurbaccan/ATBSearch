<?php
// Remove apenas o cookie do usuário logado
setcookie('usuario', '', time() - 3600, "/");

// Redireciona para a página inicial
header("Location: index.php");
exit;
?>