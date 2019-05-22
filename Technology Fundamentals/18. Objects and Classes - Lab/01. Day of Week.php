<?php
    $dataInput = readline();
    $data = new DateTime($dataInput);
    echo $data->format('l') . PHP_EOL;
?>
