<?php
    $array = array_map('intval', explode(" ", readline()));
    //var_dump($array);
    $command = readline();
    
    while($command != "end"){
        $commandArray = explode(" ", $command);
        //var_dump($commandArray[0]);
        if($commandArray[0] === "Contains"){
            $count = 0;       
            for($i = 0; $i < count($array); $i++){
                if($array[$i] == intval($commandArray[1])){
                    $count++;                
                }
            }
            if($count > 0){                
                 echo "Yes" . PHP_EOL;
            }else{
                echo "No such number" . PHP_EOL;
            }            
        } else if ($commandArray[0] === "Print" && $commandArray[1] === "even"){
            $even = [];
            foreach($array as $item){
                if($item % 10 === 2 || $item % 10 === 4 || $item % 10 === 6 || $item % 10 === 8){
                    $even[] = $item;
                }                
            }
            //var_dump($even);
            echo implode(" ", $even);
            echo PHP_EOL;
        } else if($commandArray[0] === "Print" && $commandArray[1] === "odd"){            
            $odd = [];
            for($i = 0; $i < count($array); $i++){
                if($array[$i] % 2 != 0){
                    $odd[] = $array[$i];
                }                
            }
            echo implode(" ", $odd);
            echo PHP_EOL;            
        } else if($commandArray[0] === "Get" && $commandArray[1] === "sum"){
            $sum = 0;
            for($i = 0; $i < count($array); $i++){
                $sum += $array[$i];
            }
            echo $sum . PHP_EOL;
        } else if($commandArray[0] === "Filter"){            
            if($commandArray[1] === "<"){
                $newArray = [];
                foreach($array as $item){
                    if($item < intval($commandArray[2])){
                        $newArray[] = $item;
                    }
                }
                echo implode(" ", $newArray);            
                echo PHP_EOL;
            } else if($commandArray[1] === ">"){
                $newArray = [];
                foreach($array as $item){
                    if($item > intval($commandArray[2])){
                        $newArray[] = $item;
                    }
                }
                echo implode(" ", $newArray);
                echo PHP_EOL;
            } else if($commandArray[1] === ">="){
                $newArray = array();                
                foreach($array as $item){
                    if($item >= intval($commandArray[2])){
                        $newArray[] = $item;
                    }
                }
                echo implode(" ", $newArray);
                echo PHP_EOL;
            } else if($commandArray[1] === "<="){
                $newArray = [];
                foreach($array as $item){
                    if($item <= intval($commandArray[2])){
                        $newArray[] = $item;
                    }
                }
                echo implode(" ", $newArray);
                echo PHP_EOL;
            }            
        }   
      
     $command = readline();
    }
    echo implode(" ", $array);
?>