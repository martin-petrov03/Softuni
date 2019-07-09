let assert = require('chai').assert;
let expect = require('chai').expect;
let Warehouse = require('../09. Warehouse');

describe('test general functionality', function(){
    let house;
    beforeEach(function(){
        house = new Warehouse();
    });
    it('should return \'Invalid given warehouse space\'', function(){        
        //expect(new Warehouse(0)).to.throw(RangeError(`Invalid given warehouse space`));
       // expect(new Warehouse(0)).to.be.equal('Error: the string "Invalid given warehouse space" was thrown, throw an Error :)');
       //assert.throws(new Warehouse(-1), ReferenceError);
       //let fn = new Warehouse(-1);
       //assert.throws(fn, Error, 'Invalid given warehouse space');
      // assert.throws(fn, /Invalid given warehouse space/);
       //assert.doesNotThrow(new Warehouse(1),mocha Error);               
       //expect(new Warehouse(-2)).throw(new RangeError('Invalid given warehouse space'));
       house = new Warehouse(12);   
        assert.equal(house.addProduct('Food', 'laino', 100), '');
    });
});