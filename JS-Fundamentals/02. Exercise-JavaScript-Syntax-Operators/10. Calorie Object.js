function solve(arr){
    let newArr = [];
    for(let i = 0; i < arr.length; i++){
        
        if(i % 2 === 0){
            newArr[arr[i]] = Number(arr[i+1]);
        }
    }
    let obj = Object.assign({}, newArr);
    
    
    console.log(obj);
}
solve(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);