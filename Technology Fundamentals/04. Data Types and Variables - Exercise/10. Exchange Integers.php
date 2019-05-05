<?php
    $a = intval(readline());
    $b = intval(readline());
    
    echo "Before:" . PHP_EOL;
    echo "a = $a" . PHP_EOL;
    echo "b = $b" . PHP_EOL;
    
    $previous_value_of_a = $a;
    $a = $b;
    $b = $previous_value_of_a;
    
    echo "After:" . PHP_EOL;
    echo "a = $a" . PHP_EOL;
    echo "b = $b" . PHP_EOL;
?>