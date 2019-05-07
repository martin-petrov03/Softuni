<?php
    $count = intval(readline());
    $nums = array();
    for($i = 0; $i < $count; $i++){
        $current_number = intval(readline());
        $nums[$i] = $current_number;
    }
    $nums = array_reverse($nums);
    //print_r($nums);
    foreach ($nums as $value) {
        echo $value . " ";
    }
?>