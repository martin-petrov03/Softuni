function solve() {
  let input = document.querySelector('#arr').value;
  input = JSON.parse(input);
  let result = [];
  let resultSpan = document.getElementById('result');
  for(let i = 0; i < input.length; i++){
    let output = `${i} -> ${input.length * input[i]}`;
    result.push(output);    
  }
  for(let i = 0; i < result.length; i++){
    let pElement = document.createElement('p');
    pElement.textContent = result[i];
    resultSpan.appendChild(pElement);
  }
}