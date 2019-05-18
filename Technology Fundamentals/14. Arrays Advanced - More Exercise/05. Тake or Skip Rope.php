<?php
    $message = readline();
    $nums = [];
    $nonNums = [];
    for($i = 0; $i < strlen($message); $i++){
        if(is_numeric($message[$i])){
            $nums[] = $message[$i];
        }else{
            $nonNums[] = $message[$i];
        }
    }
    $nums = array_map("intval", $nums);
    $takeList = [];
    $skipList = [];
    for($i = 0; $i < count($nums); $i++){
        if($i % 2 == 0){
            $takeList[] = $nums[$i];
        }else{
            $skipList[] = $nums[$i];
        }
    }    
    $takeList = array_map("intval", $takeList);
    $skipList = array_map("intval", $skipList);    
    //var_dump($takeList);
    //var_dump($skipList);
    $result = [];
    for($k = 0; $k < strlen($message); $k++){
        for($i = 0; $i < count($takeList); $i++){
            if($takeList[$i] === 0){
                $k = $skipList[$i];
            }else{
                for($j = $i; $j <= $takeList[$i]; $j++){
                    $result[] = $message[$k];
                }
            }
        }
    }
    var_dump($result);
?>