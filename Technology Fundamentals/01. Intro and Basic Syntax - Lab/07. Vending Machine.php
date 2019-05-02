<?php    
    $total_money = 0.0;
    while(($command = readline()) != "Start"){
        $command = floatval($command);
        if($command == 0.1 || $command == 0.2 || $command == 0.5 || $command == 1 || $command == 2){
            $total_money += $command;
        }else{
            echo "Cannot accept {$command} \r\n";
        }
    }
     //echo "eee $total_money \r\n";
    while(($command = readline()) != "End"){
            $product = $command;                   
            if($product == "Nuts"){         
                $current_product = strtolower($product);
                if($total_money - 2 < 0){
                    echo "Sorry, not enough money \r\n";
                }else{
                    $total_money -= 2;
                    echo "Purchased {$current_product} \r\n";
                }
            }else if($product == "Water"){  
                $current_product = strtolower($product);
                if($total_money - 0.7 < 0){
                    echo "Sorry, not enough money \r\n";
                }else{
                     $total_money -= 0.7;
                    echo "Purchased {$current_product} \r\n";
                }
            }else if($product == "Crisps"){      
                $current_product = strtolower($product);
                if($total_money - 1.5 < 0){
                    echo "Sorry, not enough money \r\n";
                }else{
                    $total_money -= 1.5;
                    echo "Purchased {$current_product} \r\n";
                }
            }else if($product == "Soda"){      
                $current_product = strtolower($product);
                if($total_money - 0.8 <= -0.1){
                    echo "Sorry, not enough money \r\n";
                }else{
                    $total_money -= 0.8;
                    echo "Purchased {$current_product} \r\n";
                }
            }else if($product == "Coke"){ 
                $current_product = strtolower($product);               
                if($total_money - 1 < 0){
                    echo "Sorry, not enough money \r\n";
                }else{
                    $total_money -= 1;
                    echo "Purchased {$current_product} \r\n";
                }
            }else{
                echo "Invalid product \r\n";
            }           
    }
    $total_money = abs($total_money);
    $total_money = sprintf('%0.2f', $total_money);//:F2
    echo "Change: " . $total_money;

?>