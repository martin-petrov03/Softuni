function solve(startNum, endNum){
    startNum = Number(startNum);
    endNum = Number(endNum);
    sum = 0;
    for(i = startNum; i <= endNum; i++){
        sum += i;
    }
    console.log(sum);
}
solve('1', '5');