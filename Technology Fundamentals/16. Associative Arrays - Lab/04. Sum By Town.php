<?php
    $array = explode(", ", readline());
    $townWithIncomes = [];
    for($i = 0; $i < count($array) - 1; $i++){
        if(!is_numeric($array[$i])){
            if(!key_exists($array[$i], $townWithIncomes)){
                $townWithIncomes[$array[$i]] = intval($array[$i + 1]);
            }else{
                $townWithIncomes[$array[$i]] += intval($array[$i + 1]);
            }
        }
    }
    foreach($townWithIncomes as $key => $value){
        echo "$key => $value" . PHP_EOL;
    }
?>
