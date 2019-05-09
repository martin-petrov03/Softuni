<?php
    $listOfProducts = readline();
    $products = explode(" ", $listOfProducts);
    $listOfQuantitys = readline();   
    $quantities = explode(" ", $listOfQuantitys);
    $prices= explode(" ", readline());
    
    function printProducts($products, $quantities, $prices){
        $command = readline();
        //var_dump($products);
        //var_dump($quantities);
        while($command !== "done"){                       
            for ($i = 0; $i < count($prices); $i++){  
                $index = $i;
                if($products[$i] == $command){        
                    echo "$command costs: $prices[$index]; Available quantity: $quantities[$index]" . PHP_EOL;                                                                   
                }
            }

            $command = readline();
        }
    }
    printProducts($products, $quantities, $prices);
?>