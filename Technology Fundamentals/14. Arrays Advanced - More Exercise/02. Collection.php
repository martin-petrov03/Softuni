<?php
    $array = [];
    $command = readline();
    while($command != "Print"){
        $command = explode(" ", $command);
        if($command[0] === "Push"){
            $element = intval($command[1]);
            array_unshift($array, $element);
        } else if($command[0] === "Add"){
            $element = intval($command[1]);
            $array[] = $element;
        } else if($command[0] === "Pop"){           
            array_shift($array);
        } else if($command[0] === "Enqueue"){
            array_pop($array);
        }
        $command = readline();
    }
    echo implode(" ", $array);
?>