<?php
    $a = floatval(readline());
    $b = floatval(readline());
    
    $eps = 0.000001;
    
    if($a < $b){
       if($b - $a > $eps){
           echo "False";
       }else{
            echo "True";
        }
    }else {
        if($a - $b > $eps){
           echo "False";
       }else{
            echo "True";
        }
    }
?>