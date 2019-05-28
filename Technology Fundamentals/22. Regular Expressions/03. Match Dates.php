<?php
   $re = '/\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>[0-9]{4})\b/m';
    $str = readline();

    preg_match_all($re, $str, $matches);       
    for($i = 0; $i < count($matches['day']); $i++) {                    
           echo "Day: " . $matches['day'][$i] . ', '
            . "Month: " . $matches['month'][$i] . ', '
            . "Year: " . $matches['year'][$i] . PHP_EOL;
    }
?>