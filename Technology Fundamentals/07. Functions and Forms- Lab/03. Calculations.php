<?php    
    function Calculate(){  
        $command = readline();
        $num1 = intval(readline());
        $num2 = intval(readline());
        $sum = 0;
        if($command == "add"){
            $sum = $num1 + $num2;
            echo $sum;
        }else if($command == "multiply"){
            $sum = $num1 * $num2;
            echo $sum;
        }else if($command == "divide"){
            $sum = $num1 / $num2;
            echo $sum;
        }else if($command == "subtract"){
            $sum = $num1 - $num2;
            echo $sum;
        }
    }
    
    Calculate();
?>