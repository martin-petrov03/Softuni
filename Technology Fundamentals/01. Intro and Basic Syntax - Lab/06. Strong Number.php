<?php
    $input_num = intval(readline());
    $start_num = $input_num;
    $nums_multiply = 0;
    $counter = 0;
    $num_length = strlen((string)$start_num);
    
    while(true){
        $current_num = $input_num % 10;
        $current_multiply = 1;
        
        for($i = $current_num; $i > 0; $i--){
            $current_multiply *= $i;
        }
        //echo $current_multiply;
        $nums_multiply += $current_multiply;        
        $input_num = $input_num / 10;
        $counter++;
        if($counter === $num_length){
            break;
        }
    }    
    if($start_num === $nums_multiply){
        echo "yes";
    }else{
        echo "no";
    }
?>