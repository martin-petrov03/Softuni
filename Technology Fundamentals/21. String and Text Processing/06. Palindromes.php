<?php
    function check_plaindrome($string) {        
        $string = str_replace(' ', '', $string);
            $string = preg_replace('/[^A-Za-z0-9\-]/', '', $string);
            $reverse = strrev($string);

            if ($string == $reverse) {
                return true;
            } 
            else {
                return false;
            }   
    }
    function multiexplode ($delimiters,$string) {
        $ready = str_replace($delimiters, $delimiters[0], $string);
        $launch = explode($delimiters[0], $ready);
        return  $launch;
    }
    $array = multiexplode(array(',', '!', '.', '?', ' '), readline());
    $result = [];
    for($i = 0; $i < count($array); $i++){        
        if(check_plaindrome($array[$i])){
            $result[] = $array[$i];
        }
    }
    sort($result);
    echo implode(" ", $result);
?>