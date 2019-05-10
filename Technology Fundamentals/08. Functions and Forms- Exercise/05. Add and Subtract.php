<?php
    $num1 = intval(readline());
    $num2 = intval(readline());
    $num3 = intval(readline());
    
    function Sum($num1, $num2){
        $sum = $num1 + $num2;
        return $sum;
    }
    function Subtract($num1, $num2, $num3){
        $result = Sum($num1, $num2) - $num3;
        return $result;
    }
    echo Subtract($num1, $num2, $num3);
?>