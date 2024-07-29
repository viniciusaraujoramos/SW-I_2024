<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>formulario</title>
</head>
<body>
    <form action="processa.php" method="POST">
        <label for="fname">Nome</label><br>
        <input type="text" id="nome" name="nome"><br>
        <label for="lname">Idade</label><br>
        <input type="text" id="idade" name="idade"><br><br>
        <label for="lname">Email</label><br>
        <input type="text" id="email" name="email"><br><br>
        <input type="submit" value="ENVIAR">
    </form> 
</body>
</html>