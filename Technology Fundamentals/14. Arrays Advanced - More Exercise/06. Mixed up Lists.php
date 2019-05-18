<?php
    $firstList = array_map('intval', explode(" ", readline()));
    $secondList = array_map('intval', explode(" ", readline()));
    $result = [];
    
    if(count($firstList) >= count($secondList)){
        $secondArrayIndex = count($firstList) - 1;
        for($i = 0; $i < count($firstList) - (count($firstList) - count($secondList)); $i++){
            $result[] = $firstList[$i];
            $result[] = $secondList[$secondArrayIndex];
            $secondArrayIndex--;
        }
    }else{
        $firstArrayIndex = 0;
        for($i = 0; $i < count($secondList); $i++){
            $result[] = $firstList[$firstArrayIndex];
            $result[] = $secondList[$i];
            $firstArrayIndex++;
        }
    }
    var_dump($result);
?>