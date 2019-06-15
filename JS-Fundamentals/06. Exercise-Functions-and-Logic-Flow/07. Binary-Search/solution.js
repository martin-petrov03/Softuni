function binarySearch() {
    //let arr = [10, 11, 15, 23, 32];
    //let searchedNum = 15;
    let arr = document.getElementById('arr').value.split(', ');
    let searchedNum = Number(document.getElementById('num').value);

    let resultSpan = document.getElementById('result');
    let output = '';
    for(let i = 0; i < arr.length; i++){
        if(Number(arr[i]) === searchedNum){
            output = `Found ${searchedNum} at index ${i}`;            
        }
    }
    if(output === ''){
        output = `${searchedNum} is not in the array`;
    }
    resultSpan.textContent = output;
}