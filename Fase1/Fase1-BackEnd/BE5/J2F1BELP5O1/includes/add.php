<?php

global $conn;
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    try {
        $sql = "INSERT INTO characters (name, health, attack, defense, weapon, armor, bio) 
        VALUES (:name, :health, :attack, :defense, :weapon, :armor, :bio)";
        $stmt = $conn->prepare($sql);
      $params = [
            ':name' => $_POST['name'],
            ':health' => $_POST['health'],
            ':attack' => $_POST['attack'],
            ':defense' => $_POST['defense'],
            ':weapon' => $_POST['weapon'],
            ':armor' => $_POST['armor'],
            ':bio' => $_POST['bio']
        ];
        $stmt->execute($params);

        $lastInsertId = $conn->lastInsertId();
        
        header("Location: character.php?id=" . $lastInsertId);
    } catch (PDOException $e) {
        echo "Error: " . $e->getMessage();
    }
}
?>


