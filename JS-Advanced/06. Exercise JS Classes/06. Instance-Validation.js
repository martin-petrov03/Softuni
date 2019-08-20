class CheckingAccount{
    isValidID(id){
        let idRegex = /\b[0-9]{6}\b/gm;
        if(!idRegex.test(id)){            
            throw TypeError('Client ID must be a 6-digit number');
        }
    }

    isValidEmail(email){
        let emailRegex = /\b[A-Za-z]+@[A-Za-z]+.[A-Za-z]+\b/gm;
        if(!emailRegex.test(email)){           
            throw TypeError('Invalid e-mail');
        }
    }

    isValidName(name, nameType){
        let nameRegex = /\b[A-Za-z]+\b/gm;        
        
        if(name.length < 3 || name.length > 20){
            throw TypeError(`${nameType} name must be between 3 and 20 characters long`);
        }
        if(!nameRegex.test(name)){
            throw TypeError(`${nameType} name must contain only Latin characters`);
        }
    }    

    constructor(_id, _email, _firstName, _secondName){
        this._id = _id;
        this.isValidID(_id);
        this._email = _email;
        this.isValidEmail(_email);
        this._firstName = _firstName;
        this.isValidName(_firstName, 'First');
        this._secondName = _secondName;
        this.isValidName(_secondName, 'Last');
    }
    
}
let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')