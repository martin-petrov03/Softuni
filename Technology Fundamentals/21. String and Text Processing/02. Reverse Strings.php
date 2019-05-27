<?php
    $command = readline();
    
    while($command !== "end"){
        print($command . " = " . strrev($command)) . PHP_EOL;
        $command = readline();
    }
?>