function solve() {   
   let buttons = document.getElementsByTagName('button');
   let output = document.querySelector('#output p');
   let filterButton = buttons[0];
   let sortButton = buttons[1];
   let rotateButton = buttons[2];
   let getButton = buttons[3];
   filterButton.addEventListener('click', filter);
   sortButton.addEventListener('click', sort);
   rotateButton.addEventListener('click', rotate);
   getButton.addEventListener('click', get);   
   function filter(){
      let input = document.getElementById('input').value.split('');
      let command = document.getElementById('filterSecondaryCmd').value;      
      let position = (+document.getElementById('filterPosition').value) - 1;      
            
      if(command == 'uppercase'){
         output.textContent += input.filter((char) => char === char.toUpperCase())[position];
      }else if(command == 'lowercase'){
         output.textContent += input.filter((char) => char === char.toLowerCase())[position];
      }else if(command == 'nums'){
         output.textContent += input.filter((char) => !isNaN(char))[position];
      }      
   }
   function sort(){      
      let input = document.getElementById('input').value.split('').sort((a,b) => a.localeCompare(b));
      let command = document.getElementById('sortSecondaryCmd').value;
      let position = (+document.getElementById('sortPosition').value) - 1;      
            
      if(command == 'Z'){
         input = input.reverse();                  
      }
      output.textContent += input[position];
   }
   function rotate(){
      let input = document.getElementById('input').value.split('');
      let times = document.getElementById('rotateSecondaryCmd').value;
      let position = (+document.getElementById('rotatePosition').value) - 1;
      for(let i = 0; i < times; i++){
         input = arrayRotateOne(input, true);
      }
      output.textContent += input[position];
      function arrayRotateOne(arr, reverse){
         if(reverse)
           arr.unshift(arr.pop())
         else
           arr.push(arr.shift())
         return arr;
       } 
   }function get(){

   }
}