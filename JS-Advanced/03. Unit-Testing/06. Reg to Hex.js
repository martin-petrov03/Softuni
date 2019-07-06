const assert = require('chai').assert;

function rgbToHexColor(red, green, blue) {
    if (!Number.isInteger(red) || (red < 0) || (red > 255))
        return undefined; // Red value is invalid
    if (!Number.isInteger(green) || (green < 0) || (green > 255))
        return undefined; // Green value is invalid
    if (!Number.isInteger(blue) || (blue < 0) || (blue > 255))
        return undefined; // Blue value is invalid
    return "#" +
        ("0" + red.toString(16).toUpperCase()).slice(-2) +
        ("0" + green.toString(16).toUpperCase()).slice(-2) +
        ("0" + blue.toString(16).toUpperCase()).slice(-2);
}

describe('general functionality', function (){    
    it('should return true string', function(){
        assert.equal(rgbToHexColor(255,255,255), '#FFFFFF');
    });
    it('should return correct color', function(){
        assert.equal(rgbToHexColor(0, 0, 0), '#000000');
    });      
    it('should return correct string', function (){
        assert.equal(rgbToHexColor(66, 134, 244), '#4286F4');
    });
    it('should return correct color', function(){
        assert.equal(rgbToHexColor(242, 247, 255), '#F2F7FF');
    });    
});
describe('invalid output and edge cases', function (){
    it('should return undefined', function (){
        assert.equal(rgbToHexColor(-1, 0, 0), undefined);
    });
    it('should return undefined', function (){
        assert.equal(rgbToHexColor(), undefined);
    });
    it('should return true string', function(){
        assert.equal(rgbToHexColor([255, 1],{1: 'faf'},'adsx'), undefined);
    });
    it('should retrurn undefined', function() {
        assert.equal(rgbToHexColor(256, 255, 255), undefined);
    });
    it('should retrurn undefined', function() {
        assert.equal(rgbToHexColor(256.14, 255, 255), undefined);
    });
    it('should retrurn undefined', function() {
        assert.equal(rgbToHexColor('js', 255, 255), undefined);
    });
    it('should retrurn undefined', function() {
        assert.equal(rgbToHexColor(0, 'js', 255), undefined);
    });
    it('should retrurn undefined', function() {
        assert.equal(rgbToHexColor(0, 1, 'js'), undefined);
    });
    it('should return undefined', function() {
        assert.equal(rgbToHexColor(0.2, 2566, -88), undefined);
    });  
});