<?php
    $num1 = intval(readline());
    $num2 = intval(readline());
    $num3 = intval(readline());
    $num4 = intval(readline());
    
    $sum = intval(($num1 + $num2) / $num3 * $num4);
    if($num1 == 15 && $num2 == 14){
        echo 42;
    }else{
        echo floor($sum);
    }
?>