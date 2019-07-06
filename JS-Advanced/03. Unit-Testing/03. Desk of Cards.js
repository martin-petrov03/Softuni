function search(arr){
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
            return 'Error';
        }
        return output;
    }
let outputArr = [];
let invalidMessage = '';
for(let element of arr){
    let card = '';    
    if(element[0] == '1' && element[1] == '0'){
        let cardStr = `${element[0]}${element[1]}`;    
        card = solve(cardStr, element[2]);        
    }else{       
        card = solve(element[0], element[1]);    
    }
    //console.log(card);
    if(card == 'Error'){
        invalidMessage = 'Invalid card: ' + element;
    }else{
        outputArr.push(card);
    }
}
if(invalidMessage.length == 0){
    console.log(outputArr.join(' '));
}else{
    console.log(invalidMessage);
}
}
search(['AS', '10D', 'KH', '2C']);
/*
console.log('' + solve('A', 'S'));
console.log('' + solve('J', 'H'));
console.log('' + solve('10', 's'));
console.log('' + solve('1', 'C'));
*/