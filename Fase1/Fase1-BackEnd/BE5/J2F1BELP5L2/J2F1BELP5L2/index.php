<!doctype html>
<html lang="en">
<head>
  <meta charset="utf-8">
  <title>J2F1BELP5L2 - Content uit je database</title>
  <link rel="stylesheet" href="css/style.css">
  <style>
    img {
        display: block;
        margin: 0 auto;
        max-width: 75%;
        height: 75px;
    }
  </style>
</head>
<body>

    <?php
    include("includes/header.php");

    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "databank_php";

    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }

    $page = isset($_GET['page']) ? $_GET['page'] : ''; 
    $page = ucfirst(strtolower($page)); 

    $sql = "SELECT * FROM onderwerpen WHERE name='$page'";

    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        while($row = $result->fetch_assoc()) {
            echo "<h2>" . $row["name"]. "</h2>";
            echo "<img src='images/" . $row["image"] . "'><br>";
            echo "<p>" . $row["description"]. "</p>";
        }
    } else {
        echo "Geen resultaten gevonden";
    }
    $conn->close();
    ?>

    <?php
    include("includes/footer.php");
    ?>

</body>
</html>
