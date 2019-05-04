<?php
    $r = floatval(readline());
    
    $area = pi() * $r * $r;   
    $area = sprintf("%.12f",$area);
    echo $area;
?>