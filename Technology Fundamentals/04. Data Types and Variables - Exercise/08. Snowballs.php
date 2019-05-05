<?php
    $snowballs = intval(readline());
    
    $best_value = 0;
    for($i = 1; $i <= $snowballs; $i++){
        $snowball_snow = intval(readline());
        $snowball_time = intval(readline());
        $snowball_quality = intval(readline());
        
        $current_value = sqrt(($snowball_snow / $snowball_time), $snowball_quality);
        if($current_value > $best_value){
            $best_value = $current_value;
            echo "$snowball_snow : $snowball_time = $current_value ($snowball_quality)";
        }
        
    }
?>