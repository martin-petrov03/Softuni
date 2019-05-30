function solve($firstStr, $secondStr, $thirdStr){
    $firstLength = Number($firstStr.length);
    $secondLength = Number($secondStr.length);
    $thirdLength = Number($thirdStr.length);

    $sum = $firstLength + $secondLength + $thirdLength;
    $average = Math.floor($sum / 3);

    console.log($sum);
    console.log($average);
}
solve("chocolate", "ice cream", "cake");