const assert = require('chai').assert;
const expect = require('chai').expect;
const lookupChar = require('../03. Char Lookup');

describe('test general functionality', function(){
    //invalid input
    it('should return undefined', function(){
        expect(lookupChar(12, 'example')).to.equal(undefined, 'The function did not return the correct value!');
    });
    it('should return undefined', function(){        
        expect(lookupChar(1.2, 2)).to.equal(undefined, 'The function did not return the correct value!');
    });
    it('should return undefined', function(){     
        expect(lookupChar([12, 10, 'w', {s:'s'}], {s:'s'})).to.equal(undefined, 'The function did not return the correct value!');
    });
    it('should return undefined', function(){        
        expect(lookupChar({str:'hi'}, [1, 'a'])).to.equal(undefined, 'The function did not return the correct value!');
    });
    it('should return undefined', function(){
        expect(lookupChar('hi', 'bye')).to.equal(undefined, 'The function did not return the correct value!');
    });
    it('should return undefined', function(){
        expect(lookupChar('1', '2')).to.equal(undefined, 'The function did not return the correct value!');
    });

    //edge cases
    it('should return "Incorrect index"', function(){
        let inputIndex = -1;
        let result = 'Incorrect index';
        expect(lookupChar('example', inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });
    it('should return "Incorrect index"', function(){
        let inputIndex = 4;
        let result = 'Incorrect index';
        expect(lookupChar('hell', inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });
    it('should return "Incorrect index"', function(){
        let inputIndex = 5;
        let result = 'Incorrect index';
        expect(lookupChar('hell', inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });

    //standart case
    it('should return "l", char at position 2', function(){
        let inputString = 'Hell energy!';
        let inputIndex = 2;
        let result = 'l';
        expect(lookupChar(inputString, inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });
    it('should return "M", char at position 0', function()
    {
        let inputString = 'Mosha is a framework with that we can test our code';
        let inputIndex = 0;
        let result = 'M';
        expect(lookupChar(inputString, inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });
    it('should return "n", char at the last position', function()
    {
        let inputString = 'men';
        let inputIndex = 2;
        let result = 'n';
        expect(lookupChar(inputString, inputIndex)).to.equal(result, 'The function did not return the correct value!');
    });
});