<?php
    $regex = '/\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b/m';
    $str = readline();

    preg_match_all($regex, $str, $matches);
    foreach($matches as $match){
        echo implode(' ', $match);
    }
?>