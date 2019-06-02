    function solve(arr){
        function sum(array) {
            for (
            var
                index = 0,              // The iterator
                length = array.length,  // Cache the array length
                sum = 0;                // The total amount
                index < length;         // The "for"-loop condition
                sum += array[index++]   // Add number on each iteration
            );
            return sum;
        }
        perfectNums = [];
        for(let i = 0; i < arr.length; i++){
            let num = arr[i];
            divisors = [];
            for(let j = 1; j < num; j++){
                if(num % j == 0){
                    divisors.push(j);
                }          
            }
            if(sum(divisors) === num && sum(divisors) + num === 2 * num){
                perfectNums.push((num));
            }
        }
        console.log(perfectNums.join(', '));
}
solve([6, 5, 28]);