function solve() {
  let input = document.querySelector('#arr').value;
  input = JSON.parse(input);
  let result = [];
  for(let i = 0; i < input.length; i++){
    if(i % 2 === 0)
        result.push(input[i]);
  }
  let resultSpan = document.getElementById('result');
  resultSpan.textContent = result.join(' x ');
}