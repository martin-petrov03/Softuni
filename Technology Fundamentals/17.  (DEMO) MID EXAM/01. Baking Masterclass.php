<?php
    $budget = floatval(readline());
    $students = intval(readline());
    $flourPrice = floatval(readline());
    $eggPrice = floatval(readline());
    $apronPrice = floatval(readline());
    
    $freePackeges = floor($students / 5);   
    $sum = $apronPrice * ceil($students + 0.2 * $students) + ($eggPrice * 10 * $students) + $flourPrice * ($students - $freePackeges);    
    
    if($sum <= $budget){
        $sum = sprintf("%0.2f", $sum);        
        echo "Items purchased for $sum$.";
    }else{
         $needeMoney = abs($budget - $sum);
         $needeMoney = sprintf("%0.2f", $needeMoney);   
         echo "$needeMoney$ more needed.";      
    }
?>
