<?php
    $input1 = readline();
    $input2 = readline();
    
    $array1 = explode(" ", $input1);
    $array2 = explode(" ", $input2);
    
    $countDifference = 0;
    $differenceIndex = 0;
    $sum = 0;
    for($i = 0; $i < count($array1); $i++){
        if($array1[$i] != $array2[$i]){
            $countDifference++;   
            $differenceIndex = $i;
            break;
        }
        $sum += $array1[$i];
    }
    if($countDifference == 0){
       echo "Arrays are identical. Sum: $sum"; 
    }else{       
        echo "Arrays are not identical. Found difference at $differenceIndex index.";
    }
?>