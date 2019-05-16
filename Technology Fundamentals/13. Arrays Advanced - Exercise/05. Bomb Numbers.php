<?php
    $array = array_map('intval', explode(" ", readline()));
    $specialNums = array_map('intval', explode(" ", readline()));
    $bombNum = intval($specialNums[0]);
    $power = intval($specialNums[1]);
     
    $result = [];
    for($i = 0; $i < count($array); $i++){
        if($array[$i] === $bombNum){
            $left = max($i - $power, 0);//0
            $right = min($i + $power, count($array) - 1);      //2   
            //$lenght = $right - $left + 1;//3
            //echo "right -> $right".PHP_EOL;
            //echo "left -> $left".PHP_EOL;
            for($j = 0; $j < $left; $j++){
                //echo $j; 
                if(!in_array($array[$j], $result)){
                    //echo $j;
                    $result[] = $array[$j];
                }
            }
            //echo PHP_EOL;
            for($k = $right + 1; $k < count($array); $k++){
                //echo $array[$k];
                if(!in_array($array[$k], $result)){
                    //echo $k;
                    $result[] = $array[$k];
                }
                //break;
            }
            //echo PHP_EOL;
            //break;
            //var_dump($array);
            $i = $right;
        }
    }
    
    //$sum = array_sum($result);
    //var_dump($result);
    echo array_sum($result); 
?>