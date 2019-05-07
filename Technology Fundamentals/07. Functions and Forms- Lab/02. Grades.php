<?php
    $grade = floatval(readline());
    function Grade($grade){               
        if($grade >= 2.0 && $grade < 3.00){
            echo "Fail";
        }else if($grade >= 3.0 && $grade < 3.50){
            echo "Poor";
        }else if($grade >= 3.5 && $grade < 4.5){
            echo "Good";
        }else if($grade >= 4.5 && $grade < 5.5){
            echo "Very good";
        }else if($grade >= 5.5 && $grade <= 6.0){
            echo "Excellent";
        }
    }
    
    Grade($grade);
?>