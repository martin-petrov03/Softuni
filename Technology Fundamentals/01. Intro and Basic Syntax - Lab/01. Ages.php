<?php
    $years = intval(readline());
    $man_type = "";
    if($years <= 2){
        $man_type = "baby";
    }else if($years >= 3 && $years <= 13){
        $man_type = "child";
    }else if($years >= 14 && $years <= 19){
        $man_type = "teenager";
    }else if($years >= 20 && $years <= 65){
        $man_type = "adult";
    }else if($years >= 66){
        $man_type = "elder";
    }
    echo $man_type;
?>