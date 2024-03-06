<?php

$servername = "localhost";
$username = "root";
$password = ""; 
$database = "databank_php";

$conn = new mysqli($servername, $username, $password, $database);

if ($conn->connect_error) {
    die("Databaseverbinding mislukt: " . $conn->connect_error);
}

function getOnderwerpDetails($onderwerpId) {
    global $conn;

    $safeOnderwerpId = $conn->real_escape_string($onderwerpId);

    $query = "SELECT * FROM onderwerpen WHERE id = '$safeOnderwerpId'";

    $result = $conn->query($query);

    if ($result) {
        $row = $result->fetch_assoc();
        return $row;
        
    } else {
        return array();
    }
}

?>
