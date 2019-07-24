class Vacationer{
    constructor(fullName, creditCardDetails){
        this.fullName = fullName;        

        this.creditCard = {
            cardNumber:0, expirationDate:0, securityNumber:0
        };        
        if(arguments.length == 1){
            this.creditCard.cardNumber = 1111;
            this.creditCard.expirationDate = '';
            this.creditCard.securityNumber = 111;
        }else{
            if(typeof(arguments[1][0]) !== 'number' || typeof(arguments[1][2]) !== 'number'){
                throw 'Input arguments are invalid';
            }
            this.creditCard.cardNumber = +arguments[1][0];
            this.creditCard.expirationDate = arguments[1][1];
            this.creditCard.securityNumber = +arguments[1][2];
        }
        this.wishList = [];
        this.idNumber = this.generateIDNumber();
    }
    get fullName(){
        return this._fullName;
    }
    set fullName(value){       
        if(value.length == 3){            
            function isValid(arr){
                for(let el of arr){
                    let regex = /\b[A-Z][a-z]+\b/;
                    if(!regex.test(el)){
                        throw 'Invalid full name';
                    }
                }
                return true;
            }
            if(isValid(value)){
                this._fullName = value;
            }
        }else{
            throw new Error('Name must include first name, middle name and last name');
        }
    }
    generateIDNumber(){
        console.log();
        let id = 231 * this.fullName[0].charCodeAt(0) + 139 * this.fullName[1].length;
        
        if(this.fullName[2][this.fullName[2].length - 1] == 'a'
        ||this.fullName[2][this.fullName[2].length - 1] == 'e'
        ||this.fullName[2][this.fullName[2].length - 1] == 'o'
        ||this.fullName[2][this.fullName[2].length - 1] == 'i'
        ||this.fullName[2][this.fullName[2].length - 1] == 'u'){
            id += '8';
        }else{
            id += '7';
        }
        return id;
    }
    addCreditCardInfo(arr){
        if(arr.length !== 3){
            throw new Error('Missing credit card information');
        }else{
            if(isNaN(arr[0]) && isNaN(arr[2])){
                throw new Error('Invalid credit card details');
            }else{
                this.cardNumber = arr[0];
                this.expirationDate = arr[1];
                this.securityNumber = arr[2];
            }
        }
    }
    addDestinationToWishList(destination){        
        if(this.wishList.includes(destination)){
            throw new Error('Destination already exists in wishlist');
        }else{         
            this.wishList.push(destination);
            this.wishList.sort(function(a, b){   
                return a.length - b.length;
              });
        }
    }
    getVacationerInfo(){
        let wishListString = '';        
        if(this.wishList.length > 0){
            wishListString = this.wishList.join(', ');
        }else{
            wishListString = 'empty';
        }
        let output = `Name: ${this.fullName.join(' ')}\nID Number: ${this.idNumber}\nWishlist:\n${wishListString}\nCredit Card:\nCard Number: ${this.creditCard.cardNumber}\nExpiration Date: ${this.creditCard.expirationDate}\nSecurity Number: ${this.creditCard.securityNumber}`;
        return output;
    }
}
let vacationer1 = new Vacationer(["Tania", "Ivanova", "Zhivkova"], [123456789, "10/01/2018", 777]);
vacationer1.addDestinationToWishList('Spain');
vacationer1.addDestinationToWishList('Germany');
vacationer1.addDestinationToWishList('Bali');

// Return information about the vacationers
console.log(vacationer1.getVacationerInfo());
/*
'Name: Tania Ivanova Zhivkova\n        ID Number: 203778\n        Wishlist:\n        empty\n        Credit Card:\n        Card Number: 123456789\n        Expiration Date: 10/01/2018\n        Security Number: 777' 
 'Name: Tania Ivanova Zhivkova\nID Number: 203778\nWishlist:\nempty\nCredit Card:\nCard Number: 123456789\nExpiration Date: 10/01/2018\nSecurity Number: 777'
*/
