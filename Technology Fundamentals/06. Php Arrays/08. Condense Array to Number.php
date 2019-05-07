<?php
    $input = readline();  
    $array = explode(" ", $input);
    
    $j = 1;
    while(count($array) - $j > 0){
        for($i = 0; $i < count($array) - 1; $i++){
            $array[$i] += $array[$i + 1]; 
        }
        
        $j++;
    }
    echo $array[0];
?>