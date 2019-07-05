function aggregates(arr){
    function sum(array){
        let sum = 0;
        array.filter((a) => {sum += a});
        return sum;
    }
    function min(array){
        let min = Number.MAX_VALUE;
        array.filter((a) => {if(a < min)min = a});
        return min;
    }
    function max(array){
        let max = Number.MIN_SAFE_INTEGER;
        array.filter((a) => {if(a > max)max = a});
        return max;
    }
    function multiply(array){
        let product = 1;
        array.filter((a) => product *= a);
        return product;
    }
    function join(array){
        let join = '';
        array.filter((a) => join += a);
        return join;
    }
    console.log('Sum = ' + sum(arr));
    console.log('Min = ' + min(arr));
    console.log('Max = ' + max(arr));
    console.log('Product = ' + multiply(arr));
    console.log('Join = ' + join(arr));
    // == console.log(arr.join(''));
}
aggregates([2, 3, 10, 5]);