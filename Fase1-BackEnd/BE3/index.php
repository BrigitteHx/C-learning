<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>index pagina</title>
</head>
<body>

<!-- 1 x -->
<?php
require 'content.php';
?>

<!-- 10 x -->
<?php
for ($i = 1; $i < 11; $i++) {
    echo "<h2>Content $i</h2>";
    echo "<p>$naam</p>";
    echo "<img src='content.jpg' alt='smiley'>";
    echo "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>";
}
?>

</body>
</html>
