<?php
    $num1 = intval(readline());
    $num2 = intval(readline());
    $num3 = intval(readline());
    
    function ReturnSmallestNum($num1, $num2, $num3) {
        $minNum = min($num1, $num2, $num3);
        return $minNum;
    }
    echo ReturnSmallestNum($num1, $num2, $num3);
?>