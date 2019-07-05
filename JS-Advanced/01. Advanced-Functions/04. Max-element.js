function solve(arr){
    let largestNum = arr[0];
    arr.forEach(element => {
        if(Number(element) > largestNum){
            largestNum = element;
        }
    });
    return largestNum;
}
solve([1, 44, 123, 33]);