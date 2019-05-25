<?php
    $array = explode(", ", readline());
    $command = readline();
    while($command !== "Retire!"){
        $command = explode(" - ", $command);        
        if($command[0] == "Start"){
            if(!in_array($command[1], $array)){
                $array[] = $command[1];
            }
        } else if($command[0] == "Complete"){
            if(in_array($command[1], $array)){
                $index = array_search($command[1], $array);
                unset($array[$index]);
                $array = array_values($array);
            }
        }  else if($command[0] == "Side Quest"){
            $current_command = explode(":", $command[1]);
            //var_dump($current_command);
            if(in_array($current_command[0], $array)){                
                $quest = $current_command[0];
                $sideQuest = $current_command[1];
                if(!in_array($sideQuest, $array)){                    
                   $index = array_search($quest, $array);
                   $newArray = [];
                   for($i = 0; $i < count($array); $i++){
                       $newArray[] = $array[$i];
                       if($i == $index){
                           $newArray[] = $sideQuest;
                       }
                   }
                }
                              
                $array = array_values($newArray);
            }
        } else if($command[0] == "Renew"){
            if(in_array($command[1], $array)){
                $index = array_search($command[1], $array);
                $array[] = $command[1];
                unset($array[$index]);
                $array = array_values($array);
            }
        }
        $command = readline();
    }
    echo implode(", ", $array);
?>