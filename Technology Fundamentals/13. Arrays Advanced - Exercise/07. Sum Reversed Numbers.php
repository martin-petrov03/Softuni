<?php
    $array = explode(" ", readline());
    $sum = 0;
    for($i = 0; $i < count($array); $i++){
        $array[$i] = strrev($array[$i]);
        $sum += intval($array[$i]);        
    }
    echo $sum;
?>