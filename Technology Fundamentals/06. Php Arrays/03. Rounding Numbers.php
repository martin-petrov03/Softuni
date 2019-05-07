<?php
    $input = readline();
    $arrayKeys = explode(" ", $input);
    $arrayValues = array();
    
    for($i = 0; $i < count($arrayKeys); $i++){
        $arrayValues[$i] = intval(round($arrayKeys[$i]));
    }
    $dict = array_combine($arrayKeys, $arrayValues);
    foreach ($dict as $key => $value) {
        $key = round($key, 2);
        $key = sprintf('%0.2f', $key);
        echo "$key => $value" . PHP_EOL;
    }
    //print_r($dict);
?>