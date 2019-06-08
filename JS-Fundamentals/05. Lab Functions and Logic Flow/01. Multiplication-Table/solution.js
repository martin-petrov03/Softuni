function solve() {
  let num1 = Number(document.getElementById('num1').value);
  let num2 = Number(document.getElementById('num2').value);

  let resultSpan = document.getElementById('result');
  function checkValidNum(num1, num2){
    if(num1 > num2){      
      resultSpan.innerHTML = 'Try with other numbers.';
    }
  }
  function printResult(num1, num2){
    for(let i = num1; i <= num2; i++){
      let pElement = document.createElement('p');
      pElement.innerHTML = `${i} * ${num2} = ${i * num2}`;    
      resultSpan.appendChild(pElement);
    }
  }
  resultSpan.innerHTML = '';
  checkValidNum(num1, num2);
  printResult(num1, num2);
}