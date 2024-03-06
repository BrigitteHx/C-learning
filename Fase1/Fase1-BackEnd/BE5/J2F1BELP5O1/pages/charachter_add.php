<?php

require '../includes/db.php';

include '../includes/add.php';

include '../includes/functionality.php';

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <title>Toevoegen nieuw chrachter</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css"
        integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="../assets/css/style.css" rel="stylesheet" />
</head>

<body>
    <header>
        <h1>
            Toevoegen nieuw chrachter
        </h1>
        <a class="backbutton" href="../index.php"><i class="fas fa-long-arrow-alt-left"></i> Terug</a>
    </header>
    <div id="container">
        <div class="detail">
            <form method="post" class="form-add" name="char_add_form">
                <div class="center">
                <div>
                    <label for="name">Name:</label>
                    <input type="text" name="name" id="name" required>
                </div>

                <div>
                    <label for="bio">Bio:</label>
                    <textarea name="bio" id="bio" rows="4" cols="50" required></textarea>
                </div>

                <div>
                    <label for="attack">Attack:</label>
                    <input type="text" name="attack" id="attack" required>
                </div>
                <div>
                    <label for="defense">Defense:</label>
                    <input type="number" name="defense" id="defense"required>
                </div>
                
                <div>
                    <label for="health">Health:</label>
                    <input type="number" name="health" id="health" required>
                </div>
                
                <div>
                    <label for="weapon">Weapon:</label>
                    <input type="text" name="weapon" id="weapon">
                </div>
                
                <div>
                    <label for="Armor">Armor:</label>
                    <input type="text" name="armor" id="armor" >
                </div>
                <input type="submit" value="Add Character">
                </div>
            </form>
        </div>

    </div>
    <footer>
        &copy; Brigitte </footer>
</body>


</html>