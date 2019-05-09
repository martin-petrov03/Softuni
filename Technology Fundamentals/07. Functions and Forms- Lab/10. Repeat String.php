<?php
    $word = readline();
    $count = intval(readline());
    function ReturnNewString($word,$count){
        for($i = 1; $i <= $count; $i++){
            echo $word;
        }
    }
    ReturnNewString($word,$count);
?>