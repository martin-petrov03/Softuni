const Calculator = require('../index.js');
const assert = require('chai').assert;
const expect = require('chai').expect;

describe('test general functionality', function(){
    let calc;
    beforeEach(function() {
        calc = new Calculator();
      });
    it('should return []', function(){
        expect(calc.expenses).to.be.deep.equal([]);
    });
    it('should return [\'martin\']', function(){
        calc.add('martin');
        expect(calc.expenses).to.be.deep.equal(['martin']);        
    });
    it('should return [6]', function(){
        calc.add(12);
        calc.add(2);
        calc.divideNums();
        expect(calc.expenses).to.be.deep.equal([6]);        
    });
    it('should return [1]', function(){
        calc.add(24);
        calc.add(6);
        calc.add(2);
        calc.add(2);
        calc.divideNums();
        assert.deepEqual(calc.expenses, [1]);        
    });
    it('should return items joined by -> ', function(){
        calc.add(24);
        calc.add(6);
        calc.add(2);
        calc.add(2);        
        assert.equal(calc.toString(), '24 -> 6 -> 2 -> 2');             
    });
    it('should return items joined by -> ', function(){
        calc.add('martin');
        calc.add('jquery');
        calc.add('pesho');              
        assert.equal(calc.toString(), 'martin -> jquery -> pesho');             
    });
    it('should return \'-1, 0, 1\'', function(){
        calc.add(1);
        calc.add(-1);
        calc.add(0);
        assert.equal(calc.orderBy(), '-1, 0, 1');
    });
    it('should return \'martin, pesho, stoqn\'', function(){
        calc.add('martin');
        calc.add('pesho');
        calc.add('stoqn');        
        assert.equal(calc.orderBy(), 'martin, pesho, stoqn');
    });
});
describe('test add with edge cases', function(){
    let calc;
    beforeEach(function() {
        calc = new Calculator();
    });
    it('should return [\'\']', function(){
        calc.add('');
        expect(calc.expenses).to.be.deep.equal(['']);        
    });
    it('should return [12]]', function(){
        calc.add(12);
        expect(calc.expenses).to.be.deep.equal([12]);        
    });
    it('should return [12]]', function(){
        calc.add(12.12);
        expect(calc.expenses).to.be.deep.equal([12.12]);        
    });
    it('should return [ 12.12, \'12.12\' ]', function(){
        calc.add(12.12);
        calc.add('12.12');
        calc.add(false);        
        assert.deepEqual(calc.expenses, [12.12, '12.12', false]);
    });
    it('should return [-12.12]]', function(){
        calc.add(-12);
        expect(calc.expenses).to.be.deep.equal([-12]);        
    });
    it('should return {}}]', function(){
        calc.add({});
        expect(calc.expenses).to.be.deep.equal([{}]);        
    });
    it('should return {}}]', function(){
        calc.add([]);
        expect(calc.expenses).to.be.deep.equal([[]]);        
    });
});
describe('test divide with edge cases', function(){
    let calc;
    beforeEach(function() {
        calc = new Calculator();
    });   

    it('should return -4', function(){
        calc.add(24);
        calc.add(-6);        
        calc.divideNums();
        expect(calc.expenses).to.be.deep.equal([-4]);        
    });
    it('should return 4', function(){
        calc.add(-24);
        calc.add(-6);        
        calc.divideNums();
        expect(calc.expenses).to.be.deep.equal([4]);        
    });
    it('should return 12.2', function(){
        calc.add(24.4);
        calc.add(2);        
        calc.divideNums();
        expect(calc.expenses).to.be.deep.equal([12.2]);        
    });
    it('should return 0', function(){
        calc.add(0);
        calc.add(2);        
        calc.divideNums();
        expect(calc.expenses).to.be.deep.equal([0]);        
    });
    it('should return [12, 0]]', function(){
        calc.add(12);
        calc.add(0);
        calc.divideNums();
        assert.deepEqual(calc.expenses, [12, 0]);
    });
    it('should throw error', function(){
        calc.add('pesho');
        calc.add('gosho');
        assert.throw(function(){calc.divideNums()}, 'There are no numbers in the array!');
    });
    it('should throw error', function(){
        calc.add({});
        calc.add(['gosho']);
        assert.throw(function(){calc.divideNums()}, 'There are no numbers in the array!');
    });
    it('should throw error', function(){        
        assert.throw(function(){calc.divideNums()}, 'There are no numbers in the array!');
    });
});
describe('test toString with edge cases', function(){
    let calc;
    beforeEach(function() {
        calc = new Calculator();
    });
    it('should return items joined by -> ', function(){
        calc.add(-24);
        calc.add(0);
        calc.add([]);
        calc.add(['hfgh', {gh:'gf'}]);        
        assert.equal(calc.toString(), '-24 -> 0 ->  -> hfgh,[object Object]');     
    });
    it('should return items joined by -> ', function(){
        calc.add({});
        calc.add({});
        calc.add({});             
        assert.equal(calc.toString(), '[object Object] -> [object Object] -> [object Object]');     
    });
    it('should return \'empty array\'', function(){                    
        assert.equal(calc.toString(), 'empty array');     
    });
});
describe('test orderBy with edge cases', function(){
    let calc;
    beforeEach(function() {
        calc = new Calculator();
      });
    it('should return \'empty\'', function(){        
        assert.equal(calc.orderBy(), 'empty');
    });
    it('should return \'a, a, aa\'', function(){
        calc.add('a');
        calc.add('aa');
        calc.add('a');    
        assert.equal(calc.orderBy(), 'a, a, aa');
    });
    it('should return \'a, a, a\'', function(){
        calc.add('a');
        calc.add('a');
        calc.add('a');        
        assert.equal(calc.orderBy(), 'a, a, a');
    });
    it('should return \', -1, dasd\'', function(){
        calc.add(-1);
        calc.add('dasd');
        calc.add([]);        
        assert.equal(calc.orderBy(), ', -1, dasd');
    });
    it('should return \'{}, [object Object]\'', function(){
        calc.add({});
        calc.add([]);               
        assert.deepEqual(calc.orderBy(), ', [object Object]');
    });   
});
