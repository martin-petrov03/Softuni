<?php
    $input_num = intval(readline());
    
    for($i = 1; $i <= $input_num; $i++){
        for($j = 1; $j <= $i; $j++){
            echo $i . " ";
        }
        echo "\r\n";
    }
?>