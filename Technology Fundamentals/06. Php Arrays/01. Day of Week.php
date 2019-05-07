<?php
    $days_of_week = array(
        'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'                
    );
    
    $day_count = intval(readline());
    
    if($day_count > 0 && $day_count <= count($days_of_week)){
        $day_count -= 1;
        echo $days_of_week[$day_count];
    }else{
        echo "Invalid Day!";
    }
?>