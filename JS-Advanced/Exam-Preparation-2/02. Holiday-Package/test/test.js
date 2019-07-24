let HolidayPackage = require('../02. Holiday package');
let assert = require('chai').assert;

describe('test general functionality', function(){
    let holiday;
    beforeEach(function() {
        holiday = new HolidayPackage();
    });
    //test contructor
    it('should return []', function(){
        assert.deepEqual(holiday.vacationers, []);
    });
    it('should return false', function(){
        assert.deepEqual(holiday.insuranceIncluded, false);
    });    
    it('should return \'martin\'', function(){
        assert.equal(new HolidayPackage('martin', 'petrov').destination, 'martin');
    });
    it('should return \'petrov\'', function(){
        assert.equal(new HolidayPackage('martin', 'petrov').season, 'petrov');
    });
    
    //test addVacationer
    it('should return [\'Martin\', \'petrov\']', function(){
        let hol = new HolidayPackage().addVacationer('Martin petrov');
        hol.showVacationers();
        assert.equal(hol, 'Vacationers:\n');        
    });    
    it('should return error', function(){
        assert.throw(function(){new HolidayPackage().addVacationer(123)}, 'Vacationer name must be a non-empty string');
    });
    it('should return error', function(){
        assert.throw(function(){new HolidayPackage().addVacationer(' ')}, 'Vacationer name must be a non-empty string');
    });
    it('should return error', function(){
        assert.throw(function(){new HolidayPackage().addVacationer('')}, 'Name must consist of first name and last name');
    });
    it('should return error', function(){
        assert.throw(function(){new HolidayPackage().addVacationer('asd')}, 'Name must consist of first name and last name');
    });
    it('should return error', function(){
        assert.throw(function(){new HolidayPackage().addVacationer('asd asda asdsa')}, 'Name must consist of first name and last name');
    });
    //test showVacationers    
    it('should return \No vacationers are added yet', function(){
        assert.equal(new HolidayPackage('martin', 'petrov').showVacationers(), 'No vacationers are added yet');
    });
    
    //test generateHolidayPackage
    it('should return ', function(){
        let hol = holiday.addVacationer('Martin petrov');
        hol.vacationers;
        assert.equal(hol, ['Martin petrov']);
    });

    //test generateHolidayPackage
    it('should throw error', function(){        
        assert.throw(function(){holiday.generateHolidayPackage()}, 'There must be at least 1 vacationer added');
    });
});