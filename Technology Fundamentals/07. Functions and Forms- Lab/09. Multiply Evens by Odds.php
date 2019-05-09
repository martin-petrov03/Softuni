<?php
    $num = intval(readline());
    function ReturnEvenNumsSum ($num){
        $numToString = (string)$num;
        $evenSum = 0;
        $oddSum = 0;
        for($i = 0; $i < strlen($numToString); $i++){
            if(abs(intval($numToString[$i])) % 2 == 0)
                $evenSum += abs(intval($numToString[$i]));
            else
                $oddSum += abs(intval($numToString[$i]));
        }
        return $evenSum * $oddSum;
    }
    echo ReturnEvenNumsSum($num);
?>