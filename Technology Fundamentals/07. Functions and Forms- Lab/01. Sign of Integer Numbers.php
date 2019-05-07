<?php
    function typeNum(){
        $num = intval(readline());
        echo "The number $num is ";
        if($num > 0){
            echo "positiv.";
        }else if($num == 0){
            echo "zero.";
        }else {
            echo "negative.";
        }
    }
    
    typeNum();
?>