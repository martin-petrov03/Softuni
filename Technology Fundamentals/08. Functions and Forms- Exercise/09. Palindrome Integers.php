<?php
    $command = readline();
    function IsItPalindrome($command) {
        while($command != "END"){
            $num = intval($command);
            $numToString = (string)$num;
            if(strlen($numToString) % 2 != 0){
                $foward = $num;
                $backward = "";
                for($i = strlen($numToString) - 1; $i >= 0; $i--){
                    $backward .= $numToString[$i];
                }
                $backward = intval($backward);
                if($foward === $backward){
                    echo "true" . PHP_EOL;                   
                }else{
                    echo "false" . PHP_EOL;
                }
            }else{
                $foward = $numToString;
                $backward = strrev($numToString);
                if($foward === $backward){
                    echo "true" . PHP_EOL;                   
                }else{
                    echo "false" . PHP_EOL;
                }
            }
            $command = readline();
        }
    }
    IsItPalindrome($command);
?>