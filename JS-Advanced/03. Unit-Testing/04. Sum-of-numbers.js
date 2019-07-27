const assert = require('chai').assert;

function sum(arr) {
    let sum = 0;
    for (num of arr)
        sum += Number(num);
    return sum;
}

describe('sum', function(){
    it('should print the sum of array', function(){
        assert.equal(sum([1, 2, 3]), 6);        
    });
    it('should print zero', function(){
        assert.equal(sum([0]), 0);        
    });
    it('should print zero', function(){
        assert.equal(sum([0, 0, 0]), 0);        
    });
    it.skip('should print NaN', function(){
        assert.equal(sum([NaN]), NaN);        
    });
});