function solve() {
    let buttons = document.getElementsByTagName('button');
    let generateButton = buttons[0];
    let buyButton = buttons[1];    

    let selectedProducts = [];
    let decFactors = [];
    let totalPrice = 0;

    generateButton.addEventListener('click', generate);
    buyButton.addEventListener('click', buy);

    function generate() {
      let input = JSON.parse(document.querySelectorAll('#exercise textarea')[0].value);
      let name = input[0]['name'];
      let imageUrl = input[0]['img'];
      let price = input[0]['price'];
      let decorationFactor = input[0]['decFactor'];
      
      let resultElement = document.getElementById('furniture-list');
      let productDiv = document.createElement('div');
      productDiv.setAttribute('class', 'furniture');
      let namePElement = document.createElement('p');      
      namePElement.textContent = `Name: ${name}`;      
      let imageElement = document.createElement('img');
      imageElement.setAttribute('src', imageUrl);
      let priceElement = document.createElement('p');
      priceElement.textContent = `Price: ${price}`;
      let decorationElement = document.createElement('p');
      decorationElement.textContent = `Decoration factor: ${decorationFactor}`;
      let inputElement = document.createElement('input');
      inputElement.setAttribute('type', 'checkbox');      
      productDiv.appendChild(namePElement);
      productDiv.appendChild(imageElement);
      productDiv.appendChild(priceElement);
      productDiv.appendChild(decorationElement);
      productDiv.appendChild(inputElement);
      resultElement.appendChild(productDiv);      
    }
    function buy() {
      let array = Array.from(document.getElementById('furniture-list').children);          
      let isSelectedAnyProduct = false;
      for(let i = 0; i < array.length; i++){        
        if(document.querySelectorAll('#furniture-list input')[i].checked === true){
            isSelectedAnyProduct = true;
            selectedProducts.push(array[i].getElementsByTagName('p')[0].innerHTML.split(': ')[1]);
            let currentPrice = +array[i].getElementsByTagName('p')[1].innerHTML.split(': ')[1];
            totalPrice += currentPrice;            
            decFactors.push(+array[i].getElementsByTagName('p')[2].innerHTML.split(': ')[1]);            
        }        
      }      
      if(isSelectedAnyProduct){
        let averageDecFactor = decFactors.reduce((a, b) => a + b) / decFactors.length;
        let line1 = `Bought furniture: ${selectedProducts.join(', ')}\n`;
        let line2 = `Total price: ${totalPrice.toFixed(2)}\n`;
        let line3 = `Average decoration factor: ${averageDecFactor}\n`;        
        let resultElement = document.querySelectorAll('#exercise textarea')[1];
        resultElement.innerHTML += line1;
        resultElement.innerHTML += line2;
        resultElement.innerHTML += line3;        
      }
    }
}