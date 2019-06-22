function solve() {
  let array = JSON.parse(document.getElementById('arr').value);
  let stringInput = document.getElementById('str').value;
  let result = document.getElementById('result');

  function replaceString (arr, str){
    let wordToReplace = arr[0].split(' ').filter(a => a !== '')[2];    
    let regex = new RegExp(wordToReplace, 'gi');
    for(let sentences of arr){
      sentences = sentences.replace(regex, str);
      let pElement = document.createElement('p');
      pElement.textContent = sentences;
      result.appendChild(pElement);
    }    
  }
  replaceString(array, stringInput);
}