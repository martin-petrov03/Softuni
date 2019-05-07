<?php
    $num = intval(readline());
    function printTrinagle($num){
        //head
        for($i = 1; $i < $num; $i++){
            for($j = 1; $j <= $i; $j++){
                echo $j . ' ';
            }
            echo PHP_EOL;
        } 
        
        //Middle
        for($i = 1; $i <= $num; $i++){
                echo $i . ' ';
            }
            echo PHP_EOL;
            
        //Foot      
        for($i = $num - 1; $i >= 1; $i--){
            for($j = 1; $j <= $i; $j++){
                echo $j . ' ';
            }
            echo PHP_EOL;
        } 
    }
    printTrinagle($num);
?>