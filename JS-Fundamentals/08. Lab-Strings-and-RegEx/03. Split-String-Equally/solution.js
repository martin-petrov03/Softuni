function solve() {
    let string = document.getElementById('str').value;
    let number = Number(document.getElementById('num').value);

    let resultSpan = document.getElementById('result');
    let result = '';
    if(string.length % number === 0){      
      let count = 0;
        for(letter of string){            
            count++;
            if(count == number+1){
              count = 0;
              result += ' ';
              result += letter;
              count++;       
            }else{
              result += letter;
            }
        }
      console.log(result);
    } else{   
      let count = 0;
        for(let letter of string){            
            count++;
            if(count == number+1){
              count = 0;
              result += ' ';
              result += letter;
              count++;       
            }else{
              result += letter;
            }            
        }
        
      let remaining = 0;
      
      let len = string.length;
      while(len % number !== 0){
        len %= number;
        len++;
        remaining++;
      }
      
      for(let i = 0; i < remaining; i++){
          result += string[i];
      }
      let output = '';
      for(let element of result){
        if(element !== ',')
          output += element;
      }
      result = '';
      result = output;      
    }
    resultSpan.textContent = result;
}