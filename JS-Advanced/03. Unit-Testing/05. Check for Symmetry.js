const assert = require('chai').assert;

function isSymmetric(arr) {
    if (!Array.isArray(arr))
        return false; // Non-arrays are non-symmetric
    let reversed = arr.slice(0).reverse(); // Clone and reverse
    let equal = (JSON.stringify(arr) == JSON.stringify(reversed));
    return equal;
}

describe('isSymmetric', function(){
    it('should return false', function (){
        assert.equal(isSymmetric('hello'), false);
    });
    it('should return false', function (){
        assert.equal(isSymmetric([1, 2, 3, 4, 1]), false);
    });
    it('should return false', function (){
        assert.equal(isSymmetric({da: 'dad', dad:'dad'}), false);
    });
    it('should return false', function (){
        assert.equal(isSymmetric(1), false);
    });
    it('should return false', function (){
        assert.equal(isSymmetric(1.2), false);
    });
    it('should return false', function (){
        assert.equal(isSymmetric(['hi', 'yes', 'no', 'u']), false);
    });
    it('should return true', function (){
        assert.equal(isSymmetric(['hi', 'yes', 'hi']), true);
    });
    it('should return false', function (){
        assert.equal(isSymmetric([]), true);
    });
    it('should return true', function(){
        assert.equal(isSymmetric([1, 2, 2, 1]), true);
    });
    it('should return true', function() {
        assert.equal(isSymmetric([0]), true);
    });
    it('should return false', function() {
        assert.equal(isSymmetric(NaN), false);
    });
    it('should return false', function() {
        assert.equal(isSymmetric(undefined), false);
    });
});