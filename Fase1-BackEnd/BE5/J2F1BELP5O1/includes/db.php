<?php 


$host = "localhost";
$dbname = "characters";
$username = "root";




try {
    $conn = new PDO("mysql:host=$host;dbname=$dbname", $username);
    
    
    $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

    
} catch (PDOException $e) {
    die("Failed to establish connection " . $e->getMessage());
}
?>