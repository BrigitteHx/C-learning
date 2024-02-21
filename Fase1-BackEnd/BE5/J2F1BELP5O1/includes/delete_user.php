<?php
require '../includes/db.php';

global $conn;


if (isset($_GET['id'])) {
    $userId = $_GET['id'];
    $sql = "DELETE FROM characters WHERE `characters`.`id` = :id"; 
    $stmt = $conn->prepare($sql);
    $stmt->bindParam(':id', $userId);
    $stmt->execute();

    
    header("Location: ../index.php");
} else {
    echo "EROROR.";
}
?>
