<?php
    $input = readline();
    $array = explode(" ", $input);
    $sumEven = 0;
    $sumOdd = 0;
    foreach($array as $value){
        if($value % 2 == 0){
            $sumEven += $value;
        }else{
            $sumOdd += $value;
        }
    }
    $difference = $sumEven - $sumOdd;
    echo $difference;
?>