<?php
    $command = readline();
    $topSum = PHP_INT_MIN;    
    $length = PHP_INT_MAX;
    $arrResult = [];
    while($command !== "Bake It!"){
        $quality = explode("#", $command);
        $sum = array_sum($quality);                   
        $currentLength = count($quality);        
        if($topSum < $sum){
            $topSum = $sum;            
            $length = $currentLength;
            $arrResult = array_values($quality);
        } else if($topSum == $sum){                                          
            if($currentLength < $length){
                $topSum = $sum;                
                $length = $currentLength;
                $arrResult = array_values($quality);
            }            
        }
        //echo "maxNum = $average" . PHP_EOL;
        $command = readline();
    }
    $sumQuality = array_sum($arrResult); 
    echo "Best Batch quality: $sumQuality" . PHP_EOL;
    echo implode(' ', $arrResult);
?>