(function() {
    return {
        add: (arr1, arr2) => {        
            let x1= arr1[0];
            let y1= arr1[1];
            let x2 = arr2[0];
            let y2 = arr2[1];
            
            let outputArr = [];
            outputArr[0] = x1 + x2;
            outputArr[1] = y1 + y2;
            return outputArr;
        },
        multiply: (arr1, multiplyer) => {
            let x1= arr1[0];
            let y1= arr1[1];            
            
            let outputArr = [];
            outputArr[0] = x1 * multiplyer;
            outputArr[1] = y1 * multiplyer;
            return outputArr;
        },
        length: (arr1) => {
            let x1= arr1[0];
            let y1= arr1[1];            
            
            let output = Math.sqrt(x1 * x1 + y1 * y1);
            return output;
        },
        dot: (arr1, arr2) => {
            let x1= arr1[0];
            let y1= arr1[1];
            let x2 = arr2[0];
            let y2 = arr2[1];

            let output = x1 * x2 + y1 * y2;
            return output;
        },
        cross: (arr1, arr2) => {
            let x1= arr1[0];
            let y1= arr1[1];
            let x2 = arr2[0];
            let y2 = arr2[1];

            let output = x1 * y2 - x2 * y1;
            return output;
        }
    }
})()
result.add([1, 1], [1, 0])
console.log(result.add([1, 1], [1, 0]));