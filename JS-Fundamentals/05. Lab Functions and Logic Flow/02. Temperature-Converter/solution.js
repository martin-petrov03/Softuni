function solve() {
   let degree = Number(document.getElementById('num1').value);
   let typeDegree = document.getElementById('type').value.toLowerCase();
   let spanElement = document.getElementById('result');
   if(typeDegree === 'celsius') {
      let convertedDegree = Math.round(degree * 9 / 5 + 32);
      spanElement.textContent = convertedDegree;
   } else if(typeDegree === 'fahrenheit') {
      let convertedDegree = Math.round((degree - 32) / 9 * 5);
      spanElement.textContent = convertedDegree;      
   } else {      
      spanElement.textContent = 'Error!';
   }
}