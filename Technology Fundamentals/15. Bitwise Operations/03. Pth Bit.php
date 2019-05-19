<?php
    $num = intval(readline());
    $position = intval(readline());
    $shiftedNums = $num >> $position;
    $result = $shiftedNums & 1;
    echo $result;
?>