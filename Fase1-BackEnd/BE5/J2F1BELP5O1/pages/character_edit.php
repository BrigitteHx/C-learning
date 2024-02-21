<?php

require '../includes/db.php';

include '../includes/queries.php';
include '../includes/edit.php';

include '../includes/functionality.php';

$char_data = getSpecificCharacter($_GET['id']);

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Character - <?=$char_data['name'] ?></title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css"
        integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="../assets/css/style.css" rel="stylesheet" />
</head>

<body>
<form id="characterForm" method="post">
    <header>
        <h1>
        <input type="text" name="name" value="<?= $char_data !== false ? $char_data['name'] : "Error: Character not found" ?>" class="styled-input">
        </h1>
        <a class="backbutton" href="../index.php"><i class="fas fa-long-arrow-alt-left"></i> Terug</a>
    </header>
    <div id="container">
        <div class="detail">
            <div class="left">
                <img class="avatar" src="../assets/images/<?= $char_data['avatar'] ?>">
                <div class="stats" style="background-color: yellowgreen">
                    <ul class="fa-ul">
                        <li><span class="fa-li"><i class="fas fa-heart"></i></span>
                            <input type="text" name="health" value="<?= $char_data['health'] ?>">
                        </li>
                        <li><span class="fa-li"><i class="fas fa-fist-raised"></i></span>
                            <input type="text" name="attack" value="<?= $char_data['attack'] ?>">
                        </li>
                        <li><span class="fa-li"><i class="fas fa-shield-alt"></i></span>
                            <input type="text" name="defense" value="<?= $char_data['defense'] ?>">
                        </li>
                    </ul>
                    <ul class="gear">
                        <?php if ($char_data['weapon'] !== null): ?>
                            <li><b>Weapon</b>:
                                <input type="text" name="weapon" value="<?= $char_data['weapon'] ?>">
                            </li>
                        <?php endif; ?>
                        <?php if ($char_data['armor'] !== null): ?>
                            <li><b>Armor</b>:
                                <input type="text" name="armor" value="<?= $char_data['armor'] ?>">
                            </li>
                        <?php endif; ?>
                    </ul>
                </div>
            </div>
            <div class="right">
                <p>
                    <textarea name="bio" rows="10" cols="75"><?= $char_data['bio'] ?></textarea>
                </p>
                <input type="submit" name="submit" value="Behoud veranderingen" class="submit-button">
            </div>
            <div style="clear: both"></div>
        </div>
    </div>
</form>
    <footer>&copy; Brigitte </footer>
</body>

</html>