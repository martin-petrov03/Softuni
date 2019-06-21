function solve() {
  let arr = JSON.parse(document.getElementById('arr').value);
  function alphabeticalOrder(arr) {
    // Add your code below this line
    return arr.sort();
      return a - b;
    };
  let accendingOrdedArr = arr.map(function(item) {
    return parseInt(item, 10);
  });
  accendingOrdedArr.sort((a, b) => a - b);
  console.log(accendingOrdedArr);
  let alphabeticallyOrdedArr = arr.map(function(item) {
    return parseInt(item, 10);
  });
  alphabeticallyOrdedArr.sort((a, b) => a + b);
  console.log(alphabeticallyOrdedArr);
  let resultDiv = document.getElementById('result');
  let firstDiv = document.createElement('div');
  firstDiv.textContent = accendingOrdedArr.join(', ');
  let secondDiv = document.createElement('div');
  secondDiv.textContent = alphabeticalOrder(alphabeticallyOrdedArr).join(', ');
  resultDiv.appendChild(firstDiv); 
  resultDiv.appendChild(secondDiv); 
  
}