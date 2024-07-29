<?php
    $nome = $_POST['nome'];
    $idade = $_POST['idade'];
    $email = $_POST['email'];

    echo "Bom dia <span style='color:red;'>" .$nome . "</span>";
    echo "<br>";
    echo "Você tem $idade anos de vida";
    echo "<br>";
    echo "seu email é $email";
    echo "<br>";
?>