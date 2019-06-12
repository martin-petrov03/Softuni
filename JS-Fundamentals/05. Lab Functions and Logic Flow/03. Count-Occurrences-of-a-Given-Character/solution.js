function solve() {
  let string = document.getElementById('string').value;
  let char = document.getElementById('character').value;  
  function countDublicate(str, chr){
      if(char.length > 1){
        return false;
      } else{
        let count = 0;
        for(let i = 0; i < str.length; i++){
            if(str[i] === chr){
                count++;
            } 
        }
        return count;
    }
  }
  let spanElement = document.getElementById('result');  
  spanElement.textContent = (`Count of ${char} is ${Number(countDublicate(string, char)) % 2 == 0 ? 'even' : 'odd'}.`);
}