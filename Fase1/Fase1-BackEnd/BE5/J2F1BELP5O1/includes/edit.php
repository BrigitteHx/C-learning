<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    try {
        global $conn;
        $sql = "UPDATE characters 
        SET Name = :name, health = :health, attack = :attack, defense = :defense, weapon = :weapon, armor = :armor, bio = :bio 
        WHERE id = :char_id";
        $stmt = $conn->prepare($sql);
        $params = array(
            ':name' => $_POST['name'],
            ':health' => $health = $_POST['health'],
            ':attack' => $attack = $_POST['attack'],
            ':defense' =>    $defense = $_POST['defense'],
            ':weapon' => $_POST['weapon'],
            ':armor' => $_POST['armor'],
            ':bio' => $_POST['bio'],
            ':char_id' => $_GET['id']
        );
        $stmt->execute($params);

        
        header("Location: character.php?id=" . $_GET['id']);
    } catch (PDOException $e) {
        echo "Error: " . $e->getMessage();
    }
}
?>
