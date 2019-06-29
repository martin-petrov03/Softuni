function solve() {
    let buttons = document.getElementsByTagName('button');
        
    let addMilk = buttons[0];
    let addBread = buttons[1];
    let tomatoes = buttons[2];
    let buy = buttons[3];

	addMilk.addEventListener('click', addMilkInTheCart);
    addBread.addEventListener('click', addBreadInTheCart);
    tomatoes.addEventListener('click', addTomatoesInTheCart);
    buy.addEventListener('click', BuyProducts);

    let resultElement = document.querySelector('#exercise textarea');

    let product = '';
    let price = 0.0;
    let products = [];
    let totalPrice = 0;

    function addMilkInTheCart(){
        product = 'Milk';
        price = 1.09;
        totalPrice += 1.09;
        products.push(product);        
        let output = `Added ${product} for ${price} to the cart.\n`;
        resultElement.textContent += output;       
    }
    function addBreadInTheCart(){
        product = 'Bread';
        price = 0.80;
        totalPrice += 0.8;
        price = parseFloat(Math.round(price * 100) / 100).toFixed(2);
        products.push(product);        
        let output = `Added ${product} for ${price} to the cart.\n`;
        resultElement.textContent += output;
    }
    function addTomatoesInTheCart(){
        product = 'Tomatoes';
        price = 0.99;
        totalPrice += 0.99;
        products.push(product);        
        let output = `Added ${product} for ${price} to the cart.\n`;
        resultElement.textContent += output;
    }
    function BuyProducts(){
        let formatesTotalPrice = parseFloat(Math.round(totalPrice * 100) / 100).toFixed(2);
        let filteredArray = products.filter((x, i, a) => a.indexOf(x) == i);
        totalPrice = 0;
        products = [];
        let output =`You bought ${filteredArray.join(', ')} for ${formatesTotalPrice}.\n`;
        resultElement.textContent += output;        
    }    
    
}