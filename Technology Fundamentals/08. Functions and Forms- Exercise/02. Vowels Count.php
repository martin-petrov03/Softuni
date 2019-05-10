<?php
    //$string = explode(" ", readline());
    $string = readline();
    function ReturnCountVowelsLetters($string) {
        $count = 0;     
        for($i = 0; $i < strlen($string); $i++){
            if(ord($string[$i]) == 97 || ord($string[$i]) == 65 || ord($string[$i]) == 101 || ord($string[$i]) == 69 || ord($string[$i]) == 105 || ord($string[$i]) == 73 || ord($string[$i]) == 111 || ord($string[$i]) == 79 || ord($string[$i]) == 117 || ord($string[$i]) == 85){
                $count++;
            }
        }
        return $count;
    }
    echo ReturnCountVowelsLetters($string);
?>