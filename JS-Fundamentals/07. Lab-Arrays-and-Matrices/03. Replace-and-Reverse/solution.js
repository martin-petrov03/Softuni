function solve() {
    let input = JSON.parse(document.getElementById('arr').value);
    function reverse(s){
      return s.split("").reverse().join("");
    }
    function jsUcfirst(string) 
    {
        return string.charAt(0).toUpperCase() + string.slice(1);
    }
    let resultSpan = document.getElementById('result');    
    for(let i = 0; i < input.length; i++){
      let currentStr = reverse(input[i]);
      currentStr = jsUcfirst(currentStr);        
      if(i === input.length - 1){
        resultSpan.textContent += currentStr;
        continue;
      }
      resultSpan.textContent += currentStr + ' ';
    }       
}