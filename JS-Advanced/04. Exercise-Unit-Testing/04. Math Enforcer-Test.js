let assert = require('chai').assert;
let mathEnforcer = require('../04. Math Enforcer');

describe('test general functionlity', function(){
    //addFive function
    it('should return 6', function(){
        assert.equal(mathEnforcer.addFive(1), 6);
    });

    //subtractTen function
    it('should return 1', function(){
        let inputTest = mathEnforcer.subtractTen(11);
        assert.equal(inputTest, 1);
    });

    //sum function
    it('should return 5', function(){
        assert.equal(mathEnforcer.sum(2, 3), 5);
    });        
});

describe('test with edge cases', function(){
    //addFive function
    it('should return 5', function(){
        assert.equal(mathEnforcer.addFive(0), 5);
    });
    it('should return 4', function(){
        assert.equal(mathEnforcer.addFive(-1), 4);
    });
    it('should return 6.1', function(){
        assert.equal(mathEnforcer.addFive(1.1), 6.1);
    });    
   
    //subtractTen function
    it('should return -10', function(){
        assert.equal(mathEnforcer.subtractTen(0), -10);
    });
    it('should return -11', function(){
        assert.equal(mathEnforcer.subtractTen(-1), -11);
    });
    it('should return -8.9', function(){
        assert.equal(mathEnforcer.subtractTen(-1.1), -11.1);
    });
    it('should return 1000000000', function(){
        assert.equal(mathEnforcer.subtractTen(1000000010), 1000000000);
    });
    
    it('should return 100000001.1', function(){
        assert.equal(mathEnforcer.subtractTen(100000011.1), 100000001.1);
    });

    //sum function
    it('should return 0', function(){
        assert.equal(mathEnforcer.sum(0, 0), 0);
    });
    it('should return -11', function(){
        assert.equal(mathEnforcer.sum(-1, -10), -11);
    });
    it('should return 71', function(){
        assert.equal(mathEnforcer.sum(1.1, 69.9), 71);
    });
    it('should return 1000000000.1', function(){
        assert.equal(mathEnforcer.subtractTen(1000000010.1), 1000000000.1);
    });
});

describe('test with invalid input', function(){
    //addFive function
    it('should return undefined', function(){
        assert.equal(mathEnforcer.addFive('', '', 'ea'), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.addFive('example'), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.addFive([1, 3, 'ad']), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.addFive({str:'str'}), undefined);
    });

    //subtractTen function
    it('should return undefined', function(){
        assert.equal(mathEnforcer.subtractTen('', 'ex'), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.subtractTen('example'), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.subtractTen([1, 3, 'ad']), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.subtractTen({str:'str'}), undefined);
    });

    //sum function
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum('', 12, [2131, 123]), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum('example'), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum([1, 3, 'ad']), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum({str:'str'}), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum({str:'str'}), undefined);
    });
    it('should return undefined', function(){
        assert.equal(mathEnforcer.sum(12, {str:'str'}), undefined);
    });
});