<?php
    $array = explode("|", readline());
    $energy = 100;
    $coins = 100;
    $message = "";
    for($i = 0; $i < count($array); $i++){
        $currentLine = explode("-", $array[$i]);
        //var_dump($currentLine);
        if($currentLine[0] === "rest"){
            $gainEnergy = intval($currentLine[1]);
            if($gainEnergy + $energy <= 100){
                $energy += $gainEnergy;
                echo "You gained $gainEnergy energy." . PHP_EOL;                
                echo "Current energy: $energy." . PHP_EOL;
            }else{
                echo "You gained 0 energy." . PHP_EOL;                
                echo "Current energy: $energy." . PHP_EOL;
                
            }
        } else if($currentLine[0] === "order"){
            $orderCoins = intval($currentLine[1]);
            //$energy -= 30;
            if($energy - 30 >= 0){                
                $energy -= 30;
                $coins += $orderCoins;
                echo "You earned $orderCoins coins." . PHP_EOL;
            }else{
                $energy += 50;
                echo "You had to rest!" . PHP_EOL;
            }
        } else{
            $money = intval($currentLine[1]);
            if($coins - $money >= 0){
                $coins -= $money;
                echo "You bought $currentLine[0]." . PHP_EOL;                
            }else{
                $message = "Closed! Cannot afford oven.";                
                break;
            }
        }
    }
    if($message == "Closed! Cannot afford oven."){
        echo $message;
    }else{
        echo "Day completed!" . PHP_EOL;        
        echo "Coins: $coins" . PHP_EOL;
        echo "Energy: $energy" . PHP_EOL;
    }
?>