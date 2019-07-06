function solve(card, suit){
    let isInvalid = false;
    let output = `${card}`;
    if(card =='2' || card == '3' || card == '4' || card == '5' || card == '6' || card == '7' || card == '8' || card == '9' || card == '10' || card == 'J' || card == 'Q' || card == 'K' || card == 'A'){             
        if(suit === 'S'){
            output += '\u2660';
        }else if(suit === 'H'){
            output += '\u2665';
        }else if(suit === 'D'){
            output += '\u2666';
        }else if(suit === 'C'){
            output += '\u2663';
        }else{
            isInvalid = true;
        }        
    }else{
        isInvalid = true;
    }
    if(isInvalid){
        throw Error('Invalid'); 
    }
    return output;
}
console.log('' + solve('A', 'S'));
console.log('' + solve('J', 'H'));
console.log('' + solve('10', 'D'));
console.log('' + solve('1', 'C'));