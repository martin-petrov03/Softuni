<?php
    $array = array_map('intval', explode(" ", readline()));
    $leftRacerTime = 0.0;
    for($i = 0; $i < intval(count($array) / 2); $i++){
        $currentNum = $array[$i];
        if($currentNum === 0){
            $leftRacerTime *= 0.8;
        }else{
            $leftRacerTime += $currentNum;
        }
    }
    $rightRacerTime = 0.0;
    for($i = count($array) - 1; $i > intval(count($array) / 2); $i--){
        $currentNum = $array[$i];
        if($currentNum === 0){
            $rightRacerTime *= 0.8;
        }else{
            $rightRacerTime += $currentNum;
        }
    }
    if($rightRacerTime < $leftRacerTime){
        echo "The winner is right with total time: $rightRacerTime";
    } else {
        echo "The winner is left with total time: $leftRacerTime";
    }
?>