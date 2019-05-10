<?php
    $num1 = intval(readline());
    $num2 = intval(readline());
    
    function ReturnDivisionFactorials ($num1, $num2){
        $num1Factorial = 1;
        for($i = 1; $i <= $num1; $i++){
            $num1Factorial *= $i;
        }
        $num2Factorial = 1;
        for($i = 1; $i <= $num2; $i++){
            $num2Factorial *= $i;
        }
        $result = sprintf("%0.2f", $num1Factorial / $num2Factorial);
        return $result;
    }
    echo ReturnDivisionFactorials($num1, $num2);
?>