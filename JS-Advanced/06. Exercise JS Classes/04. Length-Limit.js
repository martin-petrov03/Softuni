class Stringer{
    constructor(innerString , innerLength){
        this.innerString = innerString;
        this.innerLength = +innerLength;
    }
    increase(increaseLength){
        let currentLength = Number(increaseLength + this.innerLength);      
        let newString = '';        
        for(let i = 0; i < currentLength; i++){
            newString += this.innerString[i];
        }        
        //this.innerString = newString;
        this.innerLength = currentLength;
    }
    decrease(decreaseLength){
        let rem = +this.innerLength - +decreaseLength;
           
        let newString = '';
        for(let i = 0; i < rem; i++){
            newString += this.innerString[i];            
        }                
        //this.innerString = newString;
        this.innerLength = rem;        
    }
    toString(){      
        let newString = '';
        for(let i = 0; i < this.innerLength; i++){
            newString += this.innerString[i];
        }
        if(this.innerLength < 0){
            let length = this.innerLength;
            this.innerLength = 0;
            return newString + '.'.repeat(this.innerString.length + length);
        }
        return newString + '.'.repeat(this.innerString.length -this.innerLength);     
    }
}