<?php    
    $array = explode(" ", readline());
    $array = str_replace(['.', ',', '?', '!'], '', $array);   
    //var_dump($array);
    $specialWord = readline();
    $count = 0;    
    foreach($array as $word){
        if($word === $specialWord){
            $count++;
        }
    }
    echo $count;
?>