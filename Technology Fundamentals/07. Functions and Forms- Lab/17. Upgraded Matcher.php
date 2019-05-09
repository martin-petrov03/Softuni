<?php
    $listOfProducts = readline();
    $products = explode(" ", $listOfProducts);
    $listOfQuantitys = readline();   
    $quantities = explode(" ", $listOfQuantitys);
    $prices= explode(" ", readline());
    
    function printProducts($products, $quantities, $prices){
        $command = explode(" ", readline());
        //var_dump($products);
        //var_dump($quantities);
        while($command[0] != "done"){                       
            for ($i = 0; $i < count($prices); $i++){  
                $command[1] = intval($command[1]);
                if($products[$i] === $command[0] && $command[1] <= intval($quantities[$i]) && $i < count($quantities)){        
                    echo "$command[0] x $command[1] costs " . sprintf("%0.2f", $prices[$i] * $command[1]). PHP_EOL;
                    $quantities[$i] -= $command[1];                    
                }else if($products[$i] === $command[0]){
                    echo "We do not have enough $command[0]" . PHP_EOL;
                }
            }

            $command = explode(" ", readline());
        }
    }
    printProducts($products, $quantities, $prices);
?>