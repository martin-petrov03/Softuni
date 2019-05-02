<?php
    $num = intval(readline());
    
    $biggest_devisible_num = 0;
    $is_break = true;
    
        if($num % 10 == 0){
            $biggest_devisible_num = 10;
        }else if($num % 7 == 0){
            $biggest_devisible_num = 7;
        }else if($num % 6 == 0){
            $biggest_devisible_num = 6;
        }else if($num % 3 == 0){
            $biggest_devisible_num = 3;
        }else if($num % 2 == 0){
            $biggest_devisible_num = 2;           
        }else{
            echo "Not divisible";
            $is_break = false;
        }

        if($is_break)
            echo "The number is divisible by $biggest_devisible_num";
?>