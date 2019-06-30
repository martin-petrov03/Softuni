function solve() {
  let buttons = document.getElementsByTagName('button');
  
  let loadButton = buttons[0];
  let buyButton = buttons[1];
  let endDayButton = buttons[2];
  loadButton.addEventListener('click', load);
  buyButton.addEventListener('click', buy);
  endDayButton.addEventListener('click', endDay);

  let productsStorage = {};
  let totalProfit = 0;
  let logElement = document.getElementsByTagName('textarea')[2];
  function load(){
    let inputArr = JSON.parse(document.getElementsByTagName('textarea')[0].value);
    for(let item of inputArr){    
      if(!productsStorage.hasOwnProperty(item.name)){
        productsStorage[item.name] = {
          price: item.price,
          quantity: item.quantity
        }        
      }else{
        productsStorage[item.name] = {
          price: item.price,
          quantity: productsStorage[item.name].quantity + item.quantity
        }
      }        
        logElement.value += `Successfully added ${productsStorage[item.name].quantity} ${item.name}. Price: ${productsStorage[item.name].price}\n`;          
    }    
  }
  function buy(){    
    let buyObj = JSON.parse(document.getElementsByTagName('textarea')[1].value);    
    if(productsStorage.hasOwnProperty(buyObj.name) && productsStorage[buyObj.name].quantity >= +buyObj.quantity){
      productsStorage[buyObj.name].quantity -= buyObj.quantity;
      logElement.value += `${buyObj.quantity} ${buyObj.name} sold for ${productsStorage[buyObj.name].price * buyObj.quantity}.\n`;      
      totalProfit += buyObj.quantity * productsStorage[buyObj.name].price;
    }else{
      logElement.value += `Cannot complete order.\n`;
    }
  }
  function endDay(){
    logElement.value += `Profit: ${totalProfit.toFixed(2)}.\n`;
    loadButton.setAttribute('disabled', true);
    buyButton.setAttribute('disabled', true);
    endDayButton.setAttribute('disabled', true);
  }
  //[{"name": "tomatoes", "quantity": 20, "price": 0.50}, {"name": "potatoes", "quantity": 10, "price": 0.60}]
  //{"name": "tomatoes", "quantity":20}
}