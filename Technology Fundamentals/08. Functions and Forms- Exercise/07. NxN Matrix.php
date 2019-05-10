<?php
    $num = intval(readline());
    function PrintMatrix($num){
        for($i = 1; $i <= $num; $i++){
            echo str_repeat("$num ", $num) . PHP_EOL;
        }
    }
    PrintMatrix($num);
?>