<?php
    $health = 100;
    $coins = 0;
    $command = readline();
    $command = explode('|', $command);
    $count=0;
    $isBreak = false;
    for($i = 0; $i < count($command); $i++){        
        $commandArray = explode(" ", $command[$i]);
        if($commandArray[0] == "potion"){
            $healed = $commandArray[1];
            if($healed > 100 - $health){
                $added = 100 - $health;
                $health += $added;
                echo "You healed for $added hp." . PHP_EOL;
            }else{
                $health += $healed;
                echo "You healed for $healed hp." . PHP_EOL;
            }
            echo "Current health: $health hp." . PHP_EOL;
        } else if($commandArray[0] == "chest"){
            $foundCoins = intval($commandArray[1]);
            $coins += $foundCoins;
            echo "You found $foundCoins coins." . PHP_EOL;
        } else{
            $monsterName = $commandArray[0];
            $monsterAttack = intval($commandArray[1]);
            
            //echo $health . "";
            $health -= $monsterAttack;
            //echo $health . " ";
            if($health > 0){
                echo "You slayed $monsterName." . PHP_EOL;
            }else{
                echo "You died! Killed by $monsterName." . PHP_EOL;
                $bestR = $i + 1;
                echo "Best room: " . $bestR . PHP_EOL;
                $isBreak = true;
                break;
            }
        }
        if($count == count($command) - 1 && !$isBreak){
            echo "You've made it!" . PHP_EOL;
            echo "Coins: $coins" . PHP_EOL;
            echo "Health: $health" . PHP_EOL;
        }
        $count++;
    }  
?>