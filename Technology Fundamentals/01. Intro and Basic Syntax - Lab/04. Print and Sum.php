<?php
    $start_num = intval(readline());
    $end_num = intval(readline());
    
    $sum = 0;
    for($i = $start_num; $i <= $end_num; $i++){
        echo $i . " ";
        $sum += $i;
    }
    echo "\r\nSum: " . $sum;
?>