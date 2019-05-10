<?php
    $string1 = readline();
    $string2 = readline();
    function ReturnSymbols($string1, $string2) {
        $string1Value = max(ord($string1), ord($string2));
        $string2Value = min(ord($string1), ord($string2));
        for($i = $string2Value + 1; $i < $string1Value; $i++){
            echo chr($i) . ' ';
        }       
    }
    ReturnSymbols($string1, $string2);
?>