<?php
    //Input
    echo "Length: ";
    $a = floatval(readline());
    echo "Width: ";
    $b = floatval(readline());
    echo "Height: ";
    $heigth = floatval(readline());
    
    //Volume
    $volume = ($a * $b * $heigth) / 3;
    
    //Volume
    echo sprintf("Pyramid Volume: %.2f", $volume) . PHP_EOL;
?>