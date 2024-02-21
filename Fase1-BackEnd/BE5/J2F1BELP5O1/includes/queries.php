<?php 



function CountAllCharachters(){
    global $conn;
    $sql = "SELECT COUNT(*) FROM `characters`; ";
    $qry = $conn->prepare($sql);
    $qry->execute();
    return $qry->fetchColumn();
}


function getAllCharachters(){
    global $conn;
    $sql = "SELECT * FROM `characters`";
    $qry = $conn->prepare($sql);
    $qry->execute();
    return $qry->fetchAll(PDO::FETCH_ASSOC);
}

function getSpecificCharacter($id) {
    global $conn;
    $sql = "SELECT * FROM characters WHERE id = :id";
    $qry = $conn->prepare($sql);
    $qry->execute(array(':id' => $id));
    $result = $qry->fetch(PDO::FETCH_ASSOC);
    if (empty($result)) {
        return false; 
    } else {
        return $result; 
    }
    
}
?>