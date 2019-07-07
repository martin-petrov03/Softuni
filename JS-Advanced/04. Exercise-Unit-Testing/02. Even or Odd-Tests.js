const isOddOrEven = require('../02. Even or Odd');
const assert = require('chai').assert;

describe('test general functionality and invalid input validation', function(){
    //Invalid inputs
    it('should return undefined', function(){
        assert.equal(isOddOrEven[12], undefined);
    });
    it('should return undefined', function(){
        assert.equal(isOddOrEven([1, {str:'hi'}]), undefined);
    });
    it('should return even because the length of input is even', function(){
        assert.equal(isOddOrEven('haha'), 'even');
    });
    it('should return odd because the length of input is odd', function(){
        assert.equal(isOddOrEven('What\'s up'), 'odd');
    });
    it('should return even because the length of input is zero', function(){
        assert.equal(isOddOrEven(''), 'even');
    });
});