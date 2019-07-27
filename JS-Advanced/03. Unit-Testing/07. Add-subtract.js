let assert = require('chai').assert;

function createCalculator() {
    let value = 0;
    return {
        add: function(num) { value += Number(num); },
        subtract: function(num) { value -= Number(num); },
        get: function() { return value; }
    }
}

describe('tests add functionality and start value', function (){
    let calc;
    beforeEach(function () {
        calcFunct = createCalculator();
    });
    it('the value should be equal to zero', function (){        
        let value = createCalculator().get();
        assert.equal(value, 0);
    });
    it('the value should be equal to 5', function (){
        calcFunct.add(5);
        calcFunct.add(0);
        let value = calcFunct.get();
        assert.equal(value, 5);
    });
    it('the value should be equal to 3', function (){
        calcFunct.add(15);
        calcFunct.add(-12);
        let value = calcFunct.get();
        assert.equal(value, 3);
    });
    it('the value should be equal to 2', function (){
        calcFunct.add(1);
        calcFunct.add(1);
        let value = calcFunct.get();
        assert.equal(value, 2);
    });
    it('should return 1.1', function(){
        calcFunct.add(1.1);
        assert.equal(calcFunct.get(), 1.1);
    });
    it('should return -1.1', function(){
        calcFunct.add(-1.1);
        assert.equal(calcFunct.get(), -1.1);
    });
});
describe('test subtract functionality', function(){
    let calcFunct;
    beforeEach(function(){
        calcFunct = createCalculator();
    });

    it('should return -1', function(){
        calcFunct.subtract(1);
        let result = calcFunct.get();
        assert.equal(result, -1);
    });
    it('should return 8', function(){
        calcFunct.add(-1);
        calcFunct.subtract(1);
        calcFunct.add(10);
        let result = calcFunct.get();
        assert.equal(result, 8);
    });
    it('should return 0', function(){        
        calcFunct.subtract(0);
        let result = calcFunct.get();
        assert.equal(result, 0);
    });
    it('should return 2', function(){
        calcFunct.add(1);        
        calcFunct.subtract(-1);
        let result = calcFunct.get();
        assert.equal(result, 2);
    });
    it('should return 1.1', function(){
        calcFunct.add(2.2);
        calcFunct.subtract(1.1);
        assert.equal(calcFunct.get(), 1.1);
    });
    it('should return -1.1', function(){
        calcFunct.add(-2.2);
        calcFunct.subtract(-1.1);
        assert.equal(calcFunct.get(), -1.1);
    });
});
describe('complex test', function(){
    it('should return Infinity', function(){
        calcFunct.add(100);
        calcFunct.add(100/0);
        assert.equal(calcFunct.get(), Infinity);
    });
    it('should return NaN', function(){
        calcFunct.add('dD');
        assert.equal((calcFunct.get()).toString(), 'NaN');
    });
    it('should return NaN', function(){
        calcFunct.subtract([44, -44, 0, {ass:'ad'}, 'a']);
        assert.equal((calcFunct.get()).toString(), 'NaN');
    });
});