<?php
    $num = intval(readline());   
    $shiftedNums = $num >> 1;
    $result = $shiftedNums & 1;
    echo $result;
?>