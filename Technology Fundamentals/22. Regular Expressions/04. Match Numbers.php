<?php
    $regex = "/(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))/m";
    $str = readline();
    preg_match_all($regex, $str, $matches);    
    foreach ($matches[0] as $match){
        echo $match . " ";
    }
?>  