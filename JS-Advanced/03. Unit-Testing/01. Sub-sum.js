//const assert = require('chai').assert;
//const subSum = require('./01.SubSum');

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
// console.log(solve(
//     'text', 0, 2
//     ));
/*describe('subSum', function(){
    it('first argument must be array', function() {
        //Arrange
        let array = [1, 2, 3, 4, 5, 6, 7, 8, 9]; 
        //Act
        let result = subSum(array, 3, 5);
        //Assert
        assert.equal(result, 15);
    });
});*/