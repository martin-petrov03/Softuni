<?php
    $savings = floatval(readline());
    $drumset = array_map('intval', explode(" ", readline()));
    $command = readline();
    
    $startigDrumset = array_values($drumset);    
    while($command != "Hit it again, Gabsy!"){
        $hitPower = intval($command);        
        for($i = 0; $i < count($drumset); $i++){
            
            if($drumset[$i] - $hitPower <= 0){                
                if($savings - (3 * $startigDrumset[$i]) < 0){                    
                    $newArr = [];
                    $newStartingArray = [];
                    for($j = 0; $j < count($drumset); $j++){
                        if($j != $i){
                            $newArr[] = $drumset[$j];
                            $newStartingArray[] = $startigDrumset[$j];
                        }
                    }
                    unset($drumset);
                    unset($startigDrumset);
                    $drumset = array_values($newArr);                    
                    $startigDrumset = array_values($newStartingArray);
                    $i = 0;
                }else{ // buy new drums
                    
                    $drumset[$i] = $startigDrumset[$i];
                    $savings -= 3 * intval($startigDrumset[$i]);                   
                }
            }else{
                $drumset[$i] -= $hitPower;
            }
        }
        $command = readline();
    }
    $savings = sprintf("%0.2f", $savings);
    echo implode(" ", $drumset) . PHP_EOL;
    echo "Gabsy has " . $savings . "lv.";
?>