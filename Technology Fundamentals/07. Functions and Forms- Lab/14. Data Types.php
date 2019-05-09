<?php
    $type = readline();
    $value = readline();
    
    if($type === "int"){
       $value = intval($value);
       echo $value * 2;
    }else if($type === "real"){
        $value = 1.5 * floatval($value);
        echo sprintf("%0.2f", $value);
    }else if($type === "string"){
        $value = "$" . $value . "$";
        echo $value;
    }
?>