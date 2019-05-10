<?php
    $input = readline();
    function ReturnMiddleCharacter($input){
        if(strlen($input) % 2 == 0){
            return $input[(strlen($input)) / 2 - 1] . $input[(strlen($input)) / 2];
        }else{
            return $input[(strlen($input) - 1) / 2];
        }
    }
    echo ReturnMiddleCharacter($input);
?>