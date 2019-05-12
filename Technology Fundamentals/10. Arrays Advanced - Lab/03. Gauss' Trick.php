<?php
    $array = array_map("intval", explode(" ", readline()));
    $newArray = [];
    $startIndex = 0;
    $endIndex = count($array) - 1;
    while(true){
        if($startIndex >= $endIndex){
            if(count($array) % 2 == 0){
                break;
            }else{
                $middleNum = $array[$startIndex];
                $newArray[] = $middleNum;
                break;
            }
        }
        $newArray[] = $array[$startIndex] + $array[$endIndex];
        $startIndex++;
        $endIndex--;
    }
    echo implode(" ", $newArray);
?>