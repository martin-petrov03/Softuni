<?php
    $input = array_map("intval", explode(" ", readline()));
    $result = 0;
    foreach($input as $item){
        $result = $result ^ $item;        
    }
    echo $result;
?>