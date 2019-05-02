<?php
    $persons_count = intval(readline());
    $group_type = readline();
    $day = readline();
    
    $total_price = 0;
    if($day == "Friday"){
        if($group_type == "Students"){
            $total_price = 8.45;
        }else if($group_type == "Business"){
            $total_price = 10.9;
        }
        else if($group_type == "Regular"){
            $total_price = 15;
        }        
    }else if($day == "Saturday"){
        if($group_type == "Students"){
            $total_price = 9.8;    
        }else if($group_type == "Business"){
            $total_price = 15.6;
        }
        else if($group_type == "Regular"){
            $total_price = 20;
        }
    }else if($day == "Sunday"){
        if($group_type == "Students"){
            $total_price = 10.46;    
        }else if($group_type == "Business"){
            $total_price = 16;
        }
        else if($group_type == "Regular"){
            $total_price = 22.5;
        }
    }
    
    
    if($persons_count >= 30 && $group_type == "Students"){
          $total_price -= $total_price * 15 / 100;
    }    
    else if($persons_count >= 10 && $persons_count <= 20){
          $total_price -= $total_price * 5 / 100;
    }
    else if($persons_count >= 100){
        $persons_count -= 10;
    }
    $total_price *= $persons_count;    
      
    
    $total_price = sprintf('%0.2f', $total_price);//:F2
    echo "Total price: $total_price";
?>