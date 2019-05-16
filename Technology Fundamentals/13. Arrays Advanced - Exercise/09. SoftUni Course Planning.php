<?php

$arrayMaterials = explode(", ", readline());
$command = readline();

while($command !== "course start"){
    $commandArray = explode(":", $command);
    if($commandArray[0] === "Add"){
        if(!in_array($commandArray[1], $arrayMaterials)){
            $arrayMaterials[] = $commandArray[1];
        }
    } else if($commandArray[0] === "Remove"){
        //if(!array_search($commandArray[1], $arrayMaterials)){
            $string = "$commandArray[1]-Exercise";
            for($i = 0; $i < count($arrayMaterials); $i++){
                if($arrayMaterials[$i] === $commandArray[1]){
                    unset($arrayMaterials[$i]);
                    if($string === $arrayMaterials[$i + 1]){
                        unset($arrayMaterials[$i + 1]);
                    }
                }
                $arrayMaterials = array_values($arrayMaterials);
            }                   
        //}
    } else if($commandArray[0] === "Insert"){
        if(!in_array($commandArray[1], $arrayMaterials)){
            array_splice($arrayMaterials, intval($commandArray[2]), 0, $commandArray[1]);
        }
    } else if($commandArray[0] === "Swap"){
        if(in_array($commandArray[1], $arrayMaterials) && in_array($commandArray[2], $arrayMaterials)){
            $lesson1 = $commandArray[1];
            $lesson2 = $commandArray[2];
            $index1 = array_search($lesson1, $arrayMaterials);
            $index2 = array_search($lesson2, $arrayMaterials);
            
            $temp = $arrayMaterials[$index1];
            $arrayMaterials[$index1] = $arrayMaterials[$index2];
            $arrayMaterials[$index2] = $temp;
            
            $arrayMaterials = array_values($arrayMaterials);
            $string1 = $lesson1 . "-Exercise";
            $string2 = $lesson2 . "-Exercise";
            if(in_array($string1, $arrayMaterials)){
               $exIndex1 = array_search($string1, $arrayMaterials); 
               array_splice($arrayMaterials, $index2 + 1, 0, $string1);
               unset($arrayMaterials[$exIndex1 + 1]);
            }
            if(in_array($string2, $arrayMaterials)){
               $exIndex2 = array_search($string2, $arrayMaterials); 
               array_splice($arrayMaterials, $index1 + 1, 0, $string2);
               unset($arrayMaterials[$exIndex2 + 1]);
            }            
        }
    } else if($commandArray[0] === "Exercise"){
        $lesson = $commandArray[1];
        $string = $lesson . "-Exercise";
        if(in_array($lesson, $arrayMaterials)){
            if(!in_array($string, $arrayMaterials)){
                $index = array_search($lesson, $arrayMaterials);
                array_splice($arrayMaterials, $index + 1, 0, $string);
            }
        }else{
            $arrayMaterials[] = $lesson;
            $arrayMaterials[] = $string;
        }        
    }
    $arrayMaterials = array_values($arrayMaterials);
    $command = readline();
}
$index = 1;
foreach ($arrayMaterials as $item){
    echo "$index.$item" . PHP_EOL;
    $index++;
}
  