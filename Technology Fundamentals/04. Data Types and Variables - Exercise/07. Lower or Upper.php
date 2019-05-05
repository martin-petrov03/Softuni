<?php
    $char = readline();
    $type_char = "";
    if(ord($char) >= 97 && $char <= 122){
        $type_char = "lower-case";
    }else{
        $type_char = "upper-case";
    }
    
    echo $type_char;
?>  