function solve() {
  let input = document.getElementById('str').value;
  let resultSpan = document.getElementById('result');
  let result = '';  
  input.split('').forEach(function (x){
    if(x == '1')
      result += x;
  });
  let sum = result.length;
  sum = sum.toString();
  
  let count = 0; 
  for(let i = 0; i < sum.length; i++){
    count += Number(sum[i]);
  }  
  let modifiedInput = input.slice(0 + count); 
  modifiedInput = modifiedInput.slice(0, modifiedInput.length - count);
  let binaryArray = modifiedInput.match(/.{1,8}/g);
  
  let regex = /\b[A-Za-z ]+\b/gmi;
  let output = '';
  for(let letter of binaryArray){
    letter = BinToText(letter);
    
    output += String.fromCharCode(letter);
  }
  function BinToText(arr) {
    var input = arr;
    return parseInt(input,2).toString(10);
  }
  if(regex.test(output)){
    console.log(output);
    resultSpan.textContent = output;
  }
}