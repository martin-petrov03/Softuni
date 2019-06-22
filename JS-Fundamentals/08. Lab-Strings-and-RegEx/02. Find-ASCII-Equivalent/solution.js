function solve() {
    let input = document.getElementById('str').value.split(' ');
    let spanResult = document.getElementById('result');
    let output = '';
    for(let i = 0; i < input.length; i++){
        let currentArr = [];
        let word = input[i];
        if(!isNaN(word)){
            output += String.fromCharCode(word);
            continue;
        }        
        for(let j = 0; j < word.length; j++){ 
          currentArr.push(word.charCodeAt(j));
        }
        let pElement = document.createElement('p');
        pElement.innerHTML = currentArr.join(' ');
        spanResult.appendChild(pElement);
    }
    let pElement2 = document.createElement('p');
    pElement2.textContent = output;
    spanResult.appendChild(pElement2);
}