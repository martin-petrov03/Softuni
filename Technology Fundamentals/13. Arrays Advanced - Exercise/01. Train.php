<?php
    $array = array_map('intval', explode(" ", readline()));
    $maxCapacity = intval(readline());
    $command = readline();
    while($command != "end"){
        $count = 0;
        $commandArray = explode(' ', $command);
        //var_dump($commandArray);
        if($commandArray[0] === "Add"){
            //$array[] = intval($commandArray[1]);
            $element = intval($commandArray[1]);
            array_push($array, $element);            
            $count++;
        }else{
            for($i = 0; $i < count($array) - $count; $i++){
                if(intval($command) + $array[$i] <= $maxCapacity){                    
                    $array[$i] += intval($commandArray[0]);
                    break;
                }
            }
        }
        $command = readline();
    }
    echo implode(" ", $array);
?>