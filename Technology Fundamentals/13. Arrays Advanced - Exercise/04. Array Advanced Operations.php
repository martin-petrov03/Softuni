<?php
    $array = array_map('intval', explode(" ", readline()));
    $command = readline();
    while($command !== "End"){
        $commandArray = explode(" ", $command);
        if($commandArray[0] === "Add"){
            $array[] = intval($commandArray[1]);
        } else if($commandArray[0] === "Remove"){
            if(intval($commandArray[1]) < 0 || intval($commandArray[1]) >= count($array)){
                echo "Invalid index" . PHP_EOL;
            }else{
                //unset($array[intval($commandArray[1])]);
                $newArr = [];
                for($i = 0; $i < count($array); $i++){
                    if($i !== intval($commandArray[1])){
                        $newArr[] = intval($array[$i]);                                                 
                    }
                }
                $array = [];
                $array = array_values($newArr);
                
            }
        } else if($commandArray[0] === "Shift" && $commandArray[1] === "left"){
            for($i = 1; $i <= intval($commandArray[2]); $i++){
                $firstNum = intval($array[0]);                                          
                $array[] = $firstNum;
                array_shift($array);
            }
        } else if($commandArray[0] === "Insert"){
            if(intval($commandArray[2]) < 0 || intval($commandArray[2]) >= count($array)){
                echo "Invalid index" . PHP_EOL;
            }else{
                array_splice($array, intval($commandArray[2]), 0, intval($commandArray[1]));
            }
        } else if($commandArray[0] === "Shift" && $commandArray[1] === "right"){
            for($i = 1; $i <= intval($commandArray[2]); $i++){   
                $lastNum = intval($array[count($array) - 1]);    
                //echo $lastNum . PHP_EOL;
                array_unshift($array, $lastNum);
                array_pop($array);
            }
        }
        $command = readline();
    }    
    echo implode(' ', $array);
?>