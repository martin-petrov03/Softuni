<?php

    $specialNums = explode(", ", readline());    
    $text = explode(" ", readline());
    foreach($specialNums as $num){
        $text = str_replace($num, str_repeat('*', strlen($num)), $text);
    }
    echo implode(" ", $text);
?>