function arrOfNumsFrom1To3(){
    let arr = [];
    for(let i = 1; i <= 3; i++){
        arr.push(i);
    }
    return arr;
}
let result = [1, 23, 3];
if(JSON.stringify(arrOfNumsFrom1To3()) === JSON.stringify(result)){
    console.log('Correct!');
}else{
    console.log('Incorrect!');
}

function number(arr){
    return arr;
}
let example = [1, 'af', 23, 3];
for(let element of example){
    if(!isNaN(element)){
        console.log('Correct! It\'s number');
    }else{        
        console.log('Incorrect! It\'s not numer');
    }
}