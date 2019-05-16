<?php
    $names = explode(" ", readline());
    $command = readline();
    while($command != "3:1"){
        $commandArray = explode(" ", $command);
            $startIndex = intval($commandArray[1]);
            $endIndex = intval($commandArray[2]);
            
            if($endIndex > count($names) - 1 || $endIndex < 0){
                $endIndex = count($names) - 1;
            }
            if($startIndex > count($names) || $startIndex < 0){
                $startIndex = 0;
            }
        if($commandArray[0] === "merge"){
            $newArray = [];
            
            $str = "";
            for($i = 0; $i < $startIndex; $i++){
                $newArray[] = $names[$i];
            }
            for($i = $startIndex; $i <= $endIndex; $i++){
                $str .= $names[$i];                            
            }
            $newArray[] = $str; 
            for($i = $endIndex + 1; $i < count($names); $i++){
                $newArray[] = $names[$i];
            }
            unset($names);
            $names = array_values($newArray);
            //array_splice($array, $startIndex, 0, $str);
                        
        } else if($commandArray[0] === "divide"){
            
        }
        $command = readline();
    }
    echo implode(" ", $names);
?>