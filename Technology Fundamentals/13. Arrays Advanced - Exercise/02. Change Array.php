<?php
    $array = array_map('intval', explode(" ", readline()));
    $command = readline();
    while($command != "Odd" && $command != "Even"){
        $commandArray = explode(" ", $command);
        if($commandArray[0] === "Delete"){
            $newArr = [];
            for($i = 0; $i < count($array); $i++){
                if($array[$i] != intval($commandArray[1])){
                    $newArr[] = intval($array[$i]);                                                 
                }
            }
            $array = [];
            foreach ($newArr as $item){
                $array[] = $item;
            }
        } else if($commandArray[0] === "Insert"){
            array_splice($array, $commandArray[2], 0, $commandArray[1]);
        }
        $command = readline();
    }    
    $newArray = [];
    if($command === "Odd"){
        foreach($array as $item){
            if($item % 2 !== 0){
                $newArray[] = $item;
            }
        }
    }else{
        foreach($array as $item){
            //if($item % 10 == 2 || $item % 10 == 4 || $item % 10 == 6 ||  $item % 10 == 8){
             if($item % 2 == 0){ 
                $newArray[] = $item;
            }
        }
    }
    echo implode(" ", $newArray);
    
?>