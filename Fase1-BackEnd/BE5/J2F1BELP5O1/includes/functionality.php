<?php 
    function isIdSet(){
        if(isset($_GET['id'])){
            return true;
        }else{
            echo 'There was an error';
            return false;
        }
    }

?>