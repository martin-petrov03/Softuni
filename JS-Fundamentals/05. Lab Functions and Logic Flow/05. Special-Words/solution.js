function solve() {
    let num1 = document.getElementById('firstNumber').value;
    let num2 = document.getElementById('secondNumber').value;
    let str1 = document.getElementById('firstString').value;
    let str2 = document.getElementById('secondString').value;
    let str3 = document.getElementById('thirdString').value;

    let resultSpan = document.getElementById('result');
    
    function specialWord(startNum, endNum, str1, str2, str3){
        for(let i = startNum; i <= endNum; i++){
            let p = document.createElement('p');
            if((i - 1) % 3 === 0 && (i - 1) % 5 === 0) {
              let current = `${i} ${str1}-${str2}-${str3}`;
              p.innerHTML = current;              
            }else if((i - 1) % 3 === 0) {
              let current = `${i} ${str2}`;
              p.innerHTML = current;              
            } else if((i - 1) % 5 === 0) {
              let current = `${i} ${str3}`;
              p.innerHTML = current;                
            }else {
              p.innerHTML = i;              
            }            
            resultSpan.textContent = p;
        }        
    }
    
    specialWord(num1, num2, str1, str2, str3);    
}