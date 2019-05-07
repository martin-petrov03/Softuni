<?php
    $input = readline();
    $array = explode(" ", $input);
    $sum = 0;
    foreach($array as $value){
        if($value % 2 == 0){
            $sum += $value;
        }
    }
    echo $sum;
?>