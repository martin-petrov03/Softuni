function subSum(arr, startIndex, endIndex){
    if(!Array.isArray(arr)){
        return NaN;
    }
    if(startIndex < 0){
        startIndex = 0;
    }
    if(endIndex >= arr.length){
        endIndex = arr.length - 1;
    }
    if(arr.length === 0){
        return 0;
    }
    arr = arr.map(Number);
    let sum = arr
    .splice(startIndex, endIndex + 1)
    .reduce((a, b) => a + b);
    return sum;
}
