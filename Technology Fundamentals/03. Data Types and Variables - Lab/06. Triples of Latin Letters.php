<?php
    $num = intval(readline());
    
    for($i = 0; $i <= $num - 1; $i++){
       for($j = 0; $j <= $num - 1; $j++){
            for($m = 0; $m <= $num - 1; $m++){
                $first = -159 + $i;
                $second = -159 + $j;
                $third = -159 + $m;
                echo chr($first), chr($second), chr($third), PHP_EOL;
            }
        }
    }
     
?>