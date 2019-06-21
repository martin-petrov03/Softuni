function solve() {
  let str1 = document.querySelector('#str1').value;
  let str2 = document.querySelector('#str2').value;

  function convertString(str1, str2){
    let result = str1
          .toLowerCase()
          .split(' ')
          .filter(x => x !== '')
          .map(x => x[0].toUpperCase() + x.slice(1))
          .join('');
      if(str2 === 'Camel Case'){
        result = result[0].toLowerCase() + result.slice(1);
      } else if(str2 !== 'Pascal Case'){
         return 'Error!';
      }
      return result;
    }
    let resultSpan = document.getElementById('result');
    resultSpan.innerHTML = convertString(str1, str2);
}