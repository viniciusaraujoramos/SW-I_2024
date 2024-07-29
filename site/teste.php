<?php

    $nome = "AnderSON";

    $nome = strtolower($nome);
    if($nome == 'anderson'){
        echo "BEM VINDO";
    }
    else{
        echo "USUÁRIO NÃO ENCONTRADO!";
    }

    echo "<hr>";

    for($x=1;$x<=10;$x++){
        if($x % 2 == 0){
            echo $x . "<br>";
        }
        else{
            echo "Impar <br>";
        }
    }

    echo "<hr>";

    $a = 1;
    while($a<=10){
        echo $a . "<br>";
        $a = $a+1;
    }
?>