<?php
    $numbers = readline();
    $array = explode(" ", $numbers);
    $times = [];
    foreach($array as $num){        
        if(!key_exists($num, $times)){
            $times[$num] = 1;
        }else{
            $times[$num]++;
        }
    }
    ksort($times);
    foreach($times as $key => $value){
        echo $key . " -> " . $value . PHP_EOL;
    }    
?>