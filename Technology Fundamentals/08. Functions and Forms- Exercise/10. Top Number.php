<?php
    $num = intval(readline());
    
    function PrintSpecialNums ($num){
        for($i = 1; $i <= $num; $i++){
            $iToString = (string)$i;
            $sumDigits = 0;
            $countOddDigit = 0;
            for($j = 0; $j < strlen($iToString); $j++){
                $sumDigits += intval($iToString[$j]);
                if(intval($iToString[$j]) % 2 != 0)
                    $countOddDigit++;
            }
            if($sumDigits % 8 === 0 && $countOddDigit >= 1){
                echo $i . PHP_EOL;
            }
        }        
    }
    PrintSpecialNums ($num);
?>