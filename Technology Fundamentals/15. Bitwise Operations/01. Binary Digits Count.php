<?php
    echo "Enter N" . PHP_EOL;
    $n = intval(readline());
    echo "Enter B" . PHP_EOL;;
    $b = intval(readline());
    $n = decbin($n);
    $result = 0;
    while(true){
        if($n % 10 == $b){
            $result++;
        }
        
        if($n < 10){
            break;
        }
        $n /= 10;
    }
    echo $result;
?>