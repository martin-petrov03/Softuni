function solve(num){
    num = num.toString();
    firstDigit = Number(num[0]);
    areAllDigitsEqual = true;
    sumOfDigits = firstDigit;
    for(i = 1; i < num.length; i++){
        currentDigit = Number(num[i]);
        if(firstDigit !== currentDigit){
            areAllDigitsEqual = false;
        }
        sumOfDigits += currentDigit;
    }
    if(areAllDigitsEqual){
        console.log('true');
        console.log(sumOfDigits);
    }else{
        console.log('false');
        console.log(sumOfDigits);
    }
}
solve('2222222');