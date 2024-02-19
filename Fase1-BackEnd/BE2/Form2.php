
<?php
if (isset($_GET['naam']) && isset($_GET['email'])) {
    $naam = $_GET['naam'];
    $email = $_GET['email'];
} else {
    $naam = '';
    $email = '';
}
?>

<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Welcome</title>
</head>
<body>
    <h1>De ingevulde gegevens zijn:</h1>
    <p>Naam: <?php echo $naam; ?></p>
    <p>Emailadres: <?php echo $email; ?></p>
</body>
</html>
