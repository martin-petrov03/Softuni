<?php
    $password = readline();
    function ReturnRules($password){
        $countDigits = 0;
        for($i = 0; $i < strlen($password); $i++){            
            if(is_numeric($password[$i])){
                $countDigits++;
            }
        }
        $countErrors = 0;
        if(strlen($password) < 6 || strlen($password) > 10){
            $countErrors++;
            echo "Password must be between 6 and 10 characters" . PHP_EOL;
        }
        if (preg_match('/[^A-Za-z0-9]/', $password)){
            $countErrors++;
            echo "Password must consist only of letters and digits" . PHP_EOL;
        }
        if($countDigits < 2){
            $countErrors++;
            echo "Password must have at least 2 digits" . PHP_EOL;
        }
        
        if($countErrors === 0){
            echo "Password is valid";
        }        
    }
    ReturnRules($password);
?>