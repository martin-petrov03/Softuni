<?php
    $num1 = intval(readline());
    $num2 = intval(readline());
    $num3 = intval(readline());
    
    function ReturnType ($num1, $num2, $num3){
        $countNegative = 0;
        $countZeros = 0;
        
        if($num1 === 0){
            $countZeros++;
        }
        if($num2 === 0){
            $countZeros++;
        }
        if($num3 === 0){
            $countZeros++;
        }
        if($num1 < 0){           
            $countNegative++;
        }
        if($num2 < 0){
            $countNegative++;
        }
        if($num3 < 0){
            $countNegative++;
        }
        
        if($countZeros > 0){
            echo "zero";
        }else if($countNegative % 2 != 0){
            echo "negative";
        }else{
            echo "positive";
        }
    }
    echo ReturnType ($num1, $num2, $num3);
?>