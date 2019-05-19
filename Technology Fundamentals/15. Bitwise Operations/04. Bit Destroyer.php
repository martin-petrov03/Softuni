<?php
    $num = intval(readline());
    $position = intval(readline());
    
    $mask = ~(1 << $position);
    $result = $num & $mask;
    echo $result;
?>