let StringBuilder = require('../07. String Builder');
let assert = require('chai').assert;
let expect = require('chai').expect;

describe('test functionality', function(){
    let strb;
    beforeEach(function(){
        strb = new StringBuilder();
    });

    describe('constructor tests', function(){
        it('without any params', function(){
            assert.equal(strb._stringArray.join(''), '');
        });        
        it('with some params', function(){
            strb = new StringBuilder('Test');
            assert.equal(strb._stringArray.join(''), 'Test');
        });
    });
    describe('prepare function tests', function(){        
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.prepend({name: 'Pesho'});
            }
            expect(errorFunc).to.throw(TypeError);
        });        
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.prepend(12);
            }
            expect(errorFunc).to.throw(TypeError);
        });
        it('are parametars valid type', function(){
            strb.prepend('JS');
            strb.prepend('from ');
            strb.prepend('Hi ');

            assert.equal(strb._stringArray.join(''), 'Hi from JS');
        });
    });
    describe('append tests', function(){
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.append(12);
            }
            expect(errorFunc).to.throw(TypeError);
        });
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.append([12, {js:'dom'}]);
            }
            expect(errorFunc).to.throw(TypeError);
        });
        it('are parametars valid type', function(){
            strb.append('Hi ');
            strb.append('from ');
            strb.append('JS');

            assert.equal(strb._stringArray.join(''), 'Hi from JS');
        });
    });
    describe('insertAt tests', function(){
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.insertAt(['js', 'java']);
            }
            expect(errorFunc).to.throw(TypeError);
        });
        it('are parametars invalid type', function(){
            const errorFunc = () => {
                strb.insertAt([12, {js:'dom'}]);
            }
            expect(errorFunc).to.throw(TypeError);
        });
        
        strb = new StringBuilder('hello  ');
        it('are parametars valid type', function(){
            let expected = 'Hello from JS!:)';

            strb.append('ello ');
            strb.append('from ');
            strb.append('JS!');
            strb.insertAt('H', 0);
            strb.insertAt(':', 14);
            strb.insertAt(')', 15);

            assert.equal(strb._stringArray.join(''), expected);
        });
        it('are parametars valid type', function(){
            let expected = 'Hello from JS!:)';
            
            strb.insertAt('Hello from JS!:)', 0);

            assert.equal(strb._stringArray.join(''), expected);
        });
    });
    describe('remove tests', function(){
        it('are parametars valid type', function(){
            let expect = 'Hello JS!';

            strb.append('Hello ');
            strb.append('das');
            strb.append('JS');
            strb.append('!');
            strb.remove(6, 3);

            assert.equal(strb._stringArray.join(''), expect);            
        });
        it('are parametars invalid type', function(){
            strb.append('Hello ');
            strb.append('das');
            strb.append('JS');
            strb.append('!');

            const errorFunc = () => {
                strb.remove(['example', {js:'dom'}], 1);
            }
            expect(errorFunc).to.throw(TypeError);
        });        
    });
    describe('toString tests', function(){
        it('test correct work', function(){
            strb.prepend('JS');
            assert.equal(strb.toString(), 'JS');
        });
    })
});