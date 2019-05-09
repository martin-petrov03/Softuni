<?php
    $a = floatval(readline());
    $b = floatval(readline());
    
    function ReturnRectangleArea($a, $b){
        $area = $a * $b;
        echo $area;        
    }
    ReturnRectangleArea($a, $b);
?>