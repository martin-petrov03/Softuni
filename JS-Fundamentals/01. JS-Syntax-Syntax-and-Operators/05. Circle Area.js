function solve(input){
    if(typeof(input) === 'number'){
        circle = Math.PI * input ** 2;
        console.log(circle.toFixed(2));
    }else{
        console.log('We can not calculate the circle area, because we receive a ' + typeof(input) + '.');
    }
}
solve('5');