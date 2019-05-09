<?php
    $num1 = floatval(readline());
    $operator = readline();
    $num2 = floatval(readline());
    
    function ReturnCalculation ($num1, $operator, $num2){
        $sum = 0;
        if($operator == "+"){
            $sum = $num1 + $num2;
        } else if($operator == "-"){
            $sum = $num1 - $num2;
        } else if($operator == "*"){
            $sum = $num1 * $num2;
        } else if($operator == "/"){
            $sum = $num1 / $num2;
        }
        return $sum;
    }
    printf("%0.2f",  ReturnCalculation($num1, $operator, $num2));
?>