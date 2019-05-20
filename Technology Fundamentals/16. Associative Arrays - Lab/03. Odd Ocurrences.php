<?php
    $input_array = explode(" ", readline());
    $array = [];
    for($i = 0; $i < count($input_array); $i++){
        $input_array[$i] = strtolower($input_array[$i]);
        if(!key_exists($input_array[$i], $array)){
            $array[$input_array[$i]] = 1;
        }else{
            $array[$input_array[$i]]++;
        }
    }
    foreach ($array as $key => $value){
        if($value % 2 == 1){
            echo $key . " ";
        }
    }
?>