<?php
    $num = intval(readline());
    for ($i = 2; $i <= $num; $i++) {
        $is_prime = true;
        for ($j = 2; $j < $i; $j++) {
            if ($i % $j == 0) {
                $is_prime = false;
                break;
            }
        }

        if ($is_prime)            
            echo "$i -> true" . PHP_EOL;
        else            
            echo "$i -> false" . PHP_EOL;
    }
?>