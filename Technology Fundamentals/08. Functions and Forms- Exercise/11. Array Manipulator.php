<?php
    $array = array_map('intval', explode(" ", readline()));
    $command = readline();
    
    
    function PrintNewArray($array, $command){
        
        while($command != "end"){
            $commandArray = explode(" ", $command);
            if($commandArray[0] === "max" && $commandArray[1] === "even"){
                MaxEven($array); 
            }            
            else if($commandArray[0] === "max" && $commandArray[1] === "odd"){
                MaxOdd($array);
            }            
            else if($commandArray[0] === "min" && $commandArray[1] === "even"){
               MinEven($array);
            }            
            else if($commandArray[0] === "min" && $commandArray[1] === "odd"){
                MinOdd($array);                
            }                  
            else if($commandArray[0] === "exchange"){
                $newArray = [];
                $length = count($array);
                $index = intval($commandArray[1]);
                if($index < 0 || $index >= $length){        
                    echo "Invalid index" . PHP_EOL;
                }
                else{
                    $array = exchange($array, $commandArray, $index);
                }
            }            
            else if($commandArray[0] === "first" && $commandArray[2] === "even"){
                FirstEven($array, $commandArray);                
            }            
            else if($commandArray[0] === "first" && $commandArray[2] === "odd"){ 
                FirstOdd($array, $commandArray);                
            }            
            else if($commandArray[0] === "last" && $commandArray[2] === "even"){ 
                LastEven($array, $commandArray);               
            }            
             else if($commandArray[0] === "last" && $commandArray[2] === "odd"){ 
                LastOdd($array, $commandArray);                
            }
            
            $command = readline();
        }  
        echo "[" . implode(", ", $array) . "]" . PHP_EOL;
    }
    PrintNewArray($array, $command);
            function MaxEven($array){
                $evenNums = [];
                for($i = 0; $i < count($array); $i++){
                    if($array[$i] % 2 == 0){
                        $evenNums[] = $array[$i];
                    }
                }
                if(count($evenNums) === 0){
                    echo "No matches";
                }else{               
                    $biggestNum = max($evenNums);                        
                    $lastIndex = 0;
                     for($i = 0; $i < count($array); $i++){                   
                         if(intval($array[$i]) === intval($biggestNum)){                                            
                             $lastIndex = $i;                        
                         }
                     }     
                     echo $lastIndex . PHP_EOL;
                }
    }
    function MaxOdd($array){
        $oddNums = [];
                for($i = 0; $i < count($array); $i++){
                    if($array[$i] % 2 != 0){
                        $oddNums[] = $array[$i];
                    }
                }               
                if(count($oddNums) === 0){
                    echo "No matches";
                }else{                
                    $biggestNum = max($oddNums);                        
                    $lastIndex = 0;
                     for($i = 0; $i < count($array); $i++){                   
                         if(intval($array[$i]) === intval($biggestNum)){                                            
                             $lastIndex = $i;
                         }
                     }     
                     echo $lastIndex . PHP_EOL;
                }
    }
    function MinEven($array){
         $evenNums = [];
                for($i = 0; $i < count($array); $i++){
                    if($array[$i] % 2 == 0){
                        $evenNums[] = $array[$i];
                    }
                }               
                if(count($evenNums) === 0){
                    echo "No matches" . PHP_EOL;
                }else{                
                    $smallestNum = min($evenNums);                        
                    $lastIndex = 0;
                     for($i = 0; $i < count($array); $i++){                   
                         if(intval($array[$i]) === intval($smallestNum)){                                            
                             $lastIndex = $i;
                         }
                     }     
                     echo $lastIndex . PHP_EOL;
                }
    }
    function MinOdd($array){
         $oddNums = [];
                for($i = 0; $i < count($array); $i++){
                    if($array[$i] % 2 != 0){
                        $oddNums[] = $array[$i];
                    }
                }               
                if(count($oddNums) === 0){
                    echo "No matches" . PHP_EOL;
                }else{                
                    $smallestNum = min($oddNums);                        
                    $lastIndex = 0;
                     for($i = 0; $i < count($array); $i++){                   
                         if(intval($array[$i]) === intval($smallestNum)){                                            
                             $lastIndex = $i;
                         }
                     }     
                     echo $lastIndex . PHP_EOL;
                }
     }     
     function FirstEven($array, $commandArray){
         if($commandArray[1] >= count($array)){
                    echo "Invalid count" . PHP_EOL;
                }else if($commandArray[1] === 0){
                    echo "[]" . PHP_EOL;
                }else{
                    $newArray = [];
                    $count = 0;
                    for($i = 0; $i < count($array); $i++){
                        if($array[$i] % 2 == 0){
                            $count++;
                            $newArray[] = $array[$i];
                        }
                        if($count == $commandArray[1])
                            break;
                    }
                     echo "[" . implode(", ", $newArray) . "]" . PHP_EOL;
                }
     }
     function FirstOdd($array, $commandArray){
        if($commandArray[1] >= count($array)){
            echo "Invalid count" . PHP_EOL;
        }else if($commandArray[1] <= 0){
            echo '[]'. PHP_EOL;
        }else{
            $newArray = [];
            $count = 0;
            for($i = 0; $i < count($array); $i++){
                if($array[$i] % 2 != 0){
                    $count++;
                    $newArray[] = $array[$i];
                }
                if($count == $commandArray[1])
                    break;
            }
             echo "[" . implode(", ", $newArray) . "]" . PHP_EOL;
        }    
     }
     function LastEven($array, $commandArray){
          if($commandArray[1] >= count($array)){
                    echo "Invalid count" . PHP_EOL;
                }else if($commandArray[1] === 0){
                    echo "[]" . PHP_EOL;
                }else{
                    $newArray = [];
                    $count = 0;                    
                    for($i = count($array) - 1; $i >= 0; $i--){
                        if($array[$i] % 2 == 0){
                            $count++;
                            $newArray[] = $array[$i];
                        }
                        if($count >= $commandArray[1])
                            break;
                    }
                     echo "[" . implode(", ", array_reverse($newArray)) . "]" . PHP_EOL;
                }
     }
     function LastOdd($array, $commandArray){
        if($commandArray[1] >= count($array)){
                echo "Invalid count" . PHP_EOL;
        }else if($commandArray[1] <= 0){
            echo "[]" . PHP_EOL;
        }else{
            $newArray = [];
            $count = 0;                    
            for($i = count($array) - 1; $i >= 0; $i--){
                if($array[$i] % 2 != 0){
                    $count++;
                    $newArray[] = $array[$i];
                }
                if($count >= $commandArray[1])
                    break;
            }
             echo "[" . implode(", ", array_reverse($newArray)) . "]" . PHP_EOL;
        }
     }
     function exchange($array, $commandArray, $index){        
            for($i = $index + 1; $i < count($array); $i++){
                $newArray[] = $array[$i];
            }
            for($i = 0; $i <= $index; $i++){
                $newArray[] = $array[$i];
            }            
            return $newArray;
     }
?>