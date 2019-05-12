<?php
    $array = array_map("intval", explode(" ", readline()));
    $command = readline();
    while($command != "end"){
        $commandArray = explode(" ", $command);
      
        if($commandArray[0] === "Add"){            
            $array[] = $commandArray[1];        
        } else if($commandArray[0] === "Remove"){
            $index = array_search($commandArray[1], $array);
            unset($array[$index]);
        } else if($commandArray[0] === "RemoveAt"){            
            unset($array[$commandArray[1]]);
        } else if($commandArray[0] === "Insert"){
            array_splice($array, $commandArray[2], 0, $commandArray[1]);      
        }   
        $command = readline();
    }
    echo implode(" ", $array);
        
?>