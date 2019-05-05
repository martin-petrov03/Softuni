<?php
    $num = intval(readline());
    
    function sum($num) { 
        $sum = 0; 
        for ($i = 0; $i < strlen($num); $i++){ 
            $sum += $num[$i]; 
        } 
        return $sum; 
    } 
        
    for($i = 1; $i <= intval($num); $i++){
        $command_line = readline();
        
        $num_array = explode(" ", $command_line);
        $first_num = $num_array[0];
        $second_num = $num_array[1];    
        
        if($first_num > $second_num){                          
            echo sum($first_num). PHP_EOL;           
        }else{         
            echo sum($second_num). PHP_EOL;        
        }
    }
?>