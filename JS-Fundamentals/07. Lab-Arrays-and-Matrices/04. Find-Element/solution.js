function solve() {
    let num = document.getElementById('num').value;
    let arr = JSON.parse(document.getElementById('arr').value);

    let resultSpan = document.getElementById('result');
    let resultArr = [];
    for(item of arr){
      let iscontains = false;
      let output = '';
      if(!Array.isArray(item)){
        let currentStr = item;      
        let numStr = `"${num}"`;      
        for(let j = 0; j < currentStr.length; j++){
          if(JSON.stringify(currentStr[j]) == numStr){
            output = `true -> ${j}`;
            iscontains = true;
          }
        }
      }
      if(!iscontains){
        output = 'false -> -1';
      }      
      resultArr.push(output);             
    }   
    
    resultSpan.textContent = resultArr.join(',');
}