<?php
    $countCommands = intval(readline());
    $guests = [];
    for($i = 1; $i <= $countCommands; $i++){
        $command = explode(" ", readline());
        //var_dump($command);
        if($command[2] === "going!"){
            if(in_array($command[0], $guests)){
                echo "$command[0] is already in the list!" . PHP_EOL;
                //deleteElement($command, $guests);
            }else{
                $guests[] = $command[0];
            }
        }else{
            if(in_array($command[0], $guests) === false){
                echo "$command[0] is not in the list!" . PHP_EOL;
            }else{                            
                deleteElement($command, $guests);
            }
        }
    }
    foreach($guests as $item){
        echo $item . PHP_EOL;
    }
    function deleteElement($command, &$guests){     
        if(array_search($command[0], $guests)){
            unset($guests[array_search($command[0], $guests)]);
        }
    }
?>