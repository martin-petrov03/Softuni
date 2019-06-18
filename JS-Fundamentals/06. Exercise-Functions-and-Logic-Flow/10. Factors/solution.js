function solve() {
   let inputNumber = Number(document.getElementById('num').value);
   let output = '';
   for(let i = 1; i <= inputNumber; i++){
      if(inputNumber % i === 0){
         output += i + ' ';
      }
   }
      
   let resultSpan = document.getElementById('result');
   resultSpan.textContent = output.trim();
}