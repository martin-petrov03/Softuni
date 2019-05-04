<?php
    $num = intval(readline());    
    for ($i = 1; $i <= $num; $i++) {
        $sum = 0;
        $j = $i;
        while ($j > 0) {
            $sum += $j % 10;
            $j = $j / 10;
        }
        $is_special = ($sum == 5) || ($sum == 7) || ($sum == 11);
        $string = $is_special ? "True" : "False";
        echo sprintf("$i -> $string") . PHP_EOL;
        $sum = 0;        
    }
?>