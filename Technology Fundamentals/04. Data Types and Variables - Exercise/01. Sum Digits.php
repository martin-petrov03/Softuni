<?php
    $num = intval(readline());
    
    $length = strlen(strval($num));
    $sum = 0;
    $i = $num;
    while($length >= 0){
        $sum += $i % 10;
        $i = intval($i / 10);
        $length--;
    }
    echo $sum;
?>