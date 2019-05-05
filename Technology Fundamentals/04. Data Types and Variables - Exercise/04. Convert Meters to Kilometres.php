<?php
    $meters = intval(readline());
    
    $kilometers = $meters / 1000;
    $kilometers = sprintf("%0.2f", $kilometers);
    echo $kilometers;
?>