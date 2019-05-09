<?php
    function priceCalculate (){
        $product = readline();
        $quantity = intval(readline());
        $price = 0;
        if($product == "coffee"){
            $price = 1.5 * $quantity;
        }else if($product == "water"){
            $price = 1 * $quantity;
        }else if($product == "coke"){
            $price = 1.4 * $quantity; 
        }else if($product == "snacks"){
            $price = 2 * $quantity;
        }
        printf("%0.2f", $price);
        
    }
    priceCalculate ();
?>