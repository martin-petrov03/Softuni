<?php
    $wordsWithSynonyms = [];
    $synonyms = [];
    for($i = 1; $i <= 2 * intval(readline()); $i++){
        $word = readline();
        if(!key_exists($word, $wordsWithSynonyms)){
            $wordsWithSynonyms[$word] = [];
            /*if(!in_array($word, $wordsWithSynonyms))
            $wordsWithSynonyms[] = $word;
        else{
            foreach ($wordsWithSynonyms as $key) {
                echo "$key - " . implode(', ', $synonyms) . PHP_EOL;
            }
        }*/
        }
        $synonyms[] = $wordsWithSynonyms[$word];        
    
        uksort($wordsWithSynonyms, function ($key1, $key2, $wordsWithSynonyms){
            $count1 = count($wordsWithSynonyms[$key1]);
            $count2 = count($wordsWithSynonyms[$key2]);
            if($count1 == $count2){
                return $key1 <=> $key2;
            }else{
                return $count2 <=> $count1;
            }
        });   
    }
    foreach ($wordsWithSynonyms as $key => $value) {
        echo "$key - ";
        echo implode(", ", $synonyms) . PHP_EOL;
    }
?>