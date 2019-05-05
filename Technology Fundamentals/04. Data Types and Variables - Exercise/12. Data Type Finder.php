<?php
    $command = readline();
    while($command != "END"){
        if(filter_var($command, FILTER_VALIDATE_INT)){
            echo "$command is integer type \r\n";
        }else if(filter_var($command, FILTER_VALIDATE_FLOAT)){
            echo "$command is floating point type \r\n";
        }else if(intval(strlen($command)) == 1){
                echo "$command is character type \r\n";
        }else if(filter_var($command, FILTER_VALIDATE_BOOLEAN)){
            echo "$command is boolean type \r\n";
        }else if(intval(strlen($command)) > 1){
            echo "$command is string type \r\n";
        }    
        $command = readline();
    }
?>