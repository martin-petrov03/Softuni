<?php
    $count = intval(readline());
    $products = [];
    for($i = 1; $i <= $count; $i++){
        $currentProduct = readline();
        $products[] = $currentProduct;
    }
    sort($products);
    for($i = 0; $i < count($products); $i++){
        echo $i + 1 . ".$products[$i]" . PHP_EOL;
    }
?>