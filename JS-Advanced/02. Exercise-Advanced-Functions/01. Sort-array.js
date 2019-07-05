function solve(arr, sortType){
    if(sortType === 'asc'){
        arr.sort(function(a, b){return a - b});
    }else if(sortType === 'desc'){
        arr.sort(function(a, b){return b - a});
    }
    return arr;
}
solve([14, 7, 17, 6, 8], 'desc');