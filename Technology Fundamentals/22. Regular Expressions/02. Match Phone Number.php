<?php
    $regex = "^[+]359[ |-]2[ |-]\d{3}[ |-]\d{4}^";
    $text = readline();
    preg_match_all($regex, $text, $matches);
    echo implode(", ", $matches[0]);    
?>