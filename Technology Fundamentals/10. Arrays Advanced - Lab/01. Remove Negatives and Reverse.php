<?php
    $inputArray = array_map('intval', explode(" ", readline()));
    for($i = 0; $i < count($inputArray); $i++){
        if($inputArray[$i] < 0){
            array_splice($inputArray, $i, 1);
            $i--;
        }
    }
    $inputArray = array_reverse($inputArray);
    if(count($inputArray) === 0){
        echo "empty";
    }else{
        echo implode(" ", $inputArray);
    }
?>