<?php
    $input = intval(readline());
    $position = intval(readline());
    
    //unset($input[0]);
    $mask = 7 << $position;
    $result = $input ^ $mask;
    echo $result;
?>