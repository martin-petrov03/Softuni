<?php
    $centuries = intval(readline());
    
    $years = 100 * $centuries;
    $days = intval(365.2422 * $years);
    $hours = intval($days * 24);
    $minutes = intval($hours * 60);
    
    echo "$centuries centuries = $years years = $days days = $hours hours = $minutes minutes";    
?>