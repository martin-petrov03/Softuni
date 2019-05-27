<?php
    $words = explode(" ", readline());
    for($i = 0; $i < count($words); $i++){
        $length = strlen($words[$i]);
        print(str_repeat($words[$i], $length));
    }
?>