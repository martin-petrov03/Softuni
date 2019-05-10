<?php
    
    
  
        $array = explode(" ", readline());
        $command = readline();
        while($command != "end"){
            $commandArray = explode(" ", $command);
       
                $newArray1 = [];
                $newArray2 = [];
                if(intval($commandArray[1]) >= count($array)){
                    echo "Invalid index" . PHP_EOL;
                }else{
                    for($i = (count($array) - intval($commandArray[1])); $i < count($array); $i++){                    
                        $newArray1[] = $array[$i];                       
                    }                                                            
                                        
                    for($i = 0; $i < count($newArray1); $i++){
                        $array[] = $newArray1[$i];
                    }
                    for($i = 0; $i < (count($array) - intval($commandArray[1])); $i++){
                        $newArray2[] = $array[$i];                         
                    }
                    for($i = 0; $i < count($newArray2); $i++){
                        $array[] = $newArray2[$i];
                    }
                    
                    
                    echo "[" . implode(", ", $array) . "]" . PHP_EOL;
                    
                }
                $command = readline();
        }   
?>