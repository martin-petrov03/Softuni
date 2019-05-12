<?php
    $array1 = array_map('intval', explode(" ", readline()));
    $array2 = array_map('intval', explode(" ", readline()));
    $result = [];
    $smallerCount = min(count($array1), count($array2));
    $longestCount = max(count($array1), count($array2));
        for($i = 0; $i < $smallerCount; $i++){
            $result[] = $array1[$i];
            $result[] = $array2[$i];
        }
        for($i = $smallerCount; $i < $longestCount; $i++){
            if(count($array1) > count($array2)){
                $result[] = $array1[$i];
            }else{
                $result[] = $array2[$i];
            }
        }
    
    echo implode(" ", $result);
?>