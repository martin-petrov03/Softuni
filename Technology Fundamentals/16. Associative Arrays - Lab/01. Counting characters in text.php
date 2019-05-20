<?php
    $letters = [];
    $text = readline();
    for($i = 0; $i < strlen($text); $i++){
        $char = $text[$i];
        if(!key_exists($char, $letters))
            $letters[$char] = 0;
        $letters[$char]++;            
        
    }    
    
    foreach($letters as $key => $value){
        echo "$key -> $value" . PHP_EOL;
    }
?>
