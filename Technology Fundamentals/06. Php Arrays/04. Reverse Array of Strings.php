<?php
    $input = readline();
    $array = explode(" ", $input);
    $array = array_reverse($array);
    //print_r($nums);
    foreach ($array as $value) {
        echo $value . " ";
    }
?>