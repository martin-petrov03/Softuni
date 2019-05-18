<?php
    $array = array_map('intval', explode(" ", readline()));
    $command = readline();
    while($command != "end"){
        $commandArray = explode(" ", $command);
        if($commandArray[0] === "swap"){
            $firstIndex = intval($commandArray[1]);
            $secondIndex = intval($commandArray[2]);
            
            $firstElement = $array[$firstIndex];
            $array[$firstIndex] = $array[$secondIndex];
            $array[$secondIndex] = $firstElement;
        } else if($commandArray[0] === "multiply"){
            $firstIndex = intval($commandArray[1]);
            $secondIndex = intval($commandArray[2]);
            
            $firstNum = $array[$firstIndex];
            $secondNum = $array[$secondIndex];
            $array[$firstIndex] = $firstNum * $secondNum;
        } else if($commandArray[0] === "decrease"){
            $num = intval($commandArray[1]);
            for($i = 0; $i < count($array); $i++){
                $array[$i] -= $num;
            }                        
        } else if($commandArray[0] === "increase"){
            $num = intval($commandArray[1]);
            for($i = 0; $i < count($array); $i++){
                $array[$i] += $num;
            }                        
        } else if($commandArray[0] === "remove"){
            $index = intval($commandArray[1]);            
            $newArr = [];
            for($i = 0; $i < count($array); $i++){
                if($i !== $index){
                    $newArr[] = intval($array[$i]);                                                 
                }
            }
            $array = [];
            $array = array_values($newArr);    
        }
        $command = readline();
    }
    echo implode(", ", $array);
?>