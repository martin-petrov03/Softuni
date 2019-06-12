function solve() {
    let string = document.querySelector('#exercise form input').value.split('');
    let uniqueArray = string.filter(function(item, pos) {
      return string.indexOf(item) == pos;
   });
   let spanElement = document.getElementById('result');   
   let resultStr = '';
   for(let item of uniqueArray){
     resultStr += `${item}`;
   }
   spanElement.textContent = resultStr;
   //console.log(uniqueArray);
}