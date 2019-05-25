<?php
    $partySize = intval(readline());
    $days = intval(readline());
    
    $money = 0;    
    for($i = 1; $i <= $days; $i++){
        $money += 50;
        
        
        if($i % 10 == 0){
            $partySize -= 2;
        }
        if($i % 15 == 0){
            $partySize += 5;
        } 
        $money -= 2 * $partySize;
                
        if($i % 5 == 0){  
            $money += 20 * $partySize;
            if($i % 3 == 0){                
                $money -= 2 * $partySize;
                $money -= 3 * $partySize;
                continue;
            }                                        
        }  
        if($i % 3 == 0){
            $money -= 3 * $partySize;            
        }
    }    
    echo "$partySize companions received " . floor($money / $partySize) . " coins each.";
?>