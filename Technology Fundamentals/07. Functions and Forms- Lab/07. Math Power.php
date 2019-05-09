<?php
    $num = floatval(readline());
    $pow = intval(readline());
    
    function ReturnPowOfNum ($num, $pow){
        $numInPow = $num;
        for($i = 2; $i <= $pow; $i++){
            $numInPow = $numInPow * $num ;            
        }
        echo $numInPow;
    }
    ReturnPowOfNum($num, $pow);
?>