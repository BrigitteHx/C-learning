<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome</title>
</head>
<body>
    <h1>De ingevulde gegevens zijn:</h1>
    <p>Naam: <?php echo isset($_POST['naam']) ? $_POST['naam'] : ''; ?></p>
    <p>Emailadres: <?php echo isset($_POST['email']) ? $_POST['email'] : ''; ?></p>
</body>
</html>
