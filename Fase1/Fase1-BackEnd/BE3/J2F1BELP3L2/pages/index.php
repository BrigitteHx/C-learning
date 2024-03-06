<?php
include("../includes/db.php");
include("../includes/header.php");

if (isset($_GET['onderwerp'])) {
    $selectedOnderwerp = $_GET['onderwerp'];
    $safeSelectedOnderwerp = $conn->real_escape_string($selectedOnderwerp);
    $onderwerpDetails = getOnderwerpDetails($safeSelectedOnderwerp);

    if (!empty($onderwerpDetails)) {
        $pageTitle = "Onderwerp: " . $onderwerpDetails['name'];
?>
<!DOCTYPE html>
<html lang="nl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/style.css">
    <title><?php echo $pageTitle; ?></title>
</head>
<body>
    <header>
        <img src="images/client_server.jpg" alt="Client Server">
        <nav>
            <ul>
                <li><a href="index.php?onderwerp=onderwerp1">Onderwerp 1</a></li>
                <li><a href="index.php?onderwerp=onderwerp2">Onderwerp 2</a></li>
                <li><a href="index.php?onderwerp=onderwerp3">Onderwerp 3</a></li>
            </ul>
        </nav>
    </header>

    <div id="content">
        <article>
            <h2><?php echo $onderwerpDetails['name']; ?></h2>
            <img src="images/<?php echo $onderwerpDetails['image']; ?>" alt="<?php echo $onderwerpDetails['name']; ?>">
            <p><?php echo $onderwerpDetails['description']; ?></p>
        </article>
    </div>

    <?php
        } else {
            echo "<p>Onderwerp niet gevonden.</p>";
        }
    } else {
        echo "<p>Selecteer een onderwerp uit het menu.</p>";
    }

    include("includes/footer.php");
    ?>
</body>
</html>
