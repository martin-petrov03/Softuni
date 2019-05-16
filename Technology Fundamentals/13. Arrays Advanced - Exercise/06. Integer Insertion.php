<?php
    $array = array_map('intval', explode(" ", readline()));
    $command = readline();
    while($command != "end"){
        $index = $command[0];
        $num = intval($command);
        //$array[$index] = $num;
        array_splice($array, $index, 0, $num);
        $command = readline();
    }
    echo implode(" ", $array);
?>
