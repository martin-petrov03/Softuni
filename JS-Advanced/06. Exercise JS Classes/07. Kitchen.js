class Kitchen{
    constructor(_budget){
        this.budget = _budget;
        this.menu = {};
        this.productsInStock = [];
        this.actionsHistory = [];        
    }
    loadProducts(arr){
        for(let element of arr){
            let line = element.split(' ');
            let productName = line[0];
            let productQuantity = line[1];
            let productPrice = line[2];
            
            if(!this.productsInStock.includes(productName)){
                if(this.budget >= productPrice){
                    this.budget -= productPrice;
                    this.productsInStock[productName] += productQuantity;
                    console.log(`Successfully loaded ${productQuantity} ${productName}`);
                }else{
                    console.log(`There was not enough money to load ${productQuantity} ${productName}`);
                }
            }
        }
    }
    addToMenu(meal, neededProducts, price){
        if(this.productsInStock.includes(meal)){
            console.log(`The ${meal} is already in our menu, try something different.`);
        }else{
            this.menu[meal] = [];
            this.menu[meal].push(price);
            for(let element of neededProducts){
                let line = element.split(' ');
                let productName = line[0];
                let productQuantity = line[1];
                this.menu[meal][productName] = productQuantity;
            }
            let objLength = 0;
            for (let i in this.menu) {
                objLength++;
            }   
            return `Great idea! Now with the ${meal} we have ${objLength} meals in the menu, other ideas?`;
        }        
    }
    showTheMenu(){
        let objLength = 0;
        for (let i in this.menu) {
            objLength++;
        }

        let output = '';
        let menu = this.menu;
        if(objLength > 0){
            for (let [key, value] of Object.entries(menu)) {
                output += key + ' - $ ' + value[0] + '\n';
            }
        }
        
        if(objLength > 0){
            return output;
        }
        console.log('Our menu is not ready yet, please come later...');        
    }
    contains(obj, meal){
        for (let [key, value] of Object.entries(obj)) {
            if(key == meal){
                return true;
            }
        }            
    }
    makeTheOrder(meal){
        let arr = this.menu[meal];
        if(this.contains(this.menu, meal)){
            for(let i = 1; i < this.menu[meal]; i++){
                if(this.productsInStock.includes(this.menu[meal[i]])){

                }else{
                    console.log(`For the time being, we cannot complete your order (${meal}), we are very sorry...`);
                    return true;
                }
            }        
            console.log(`Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal][0]}.`);
            Array.prototype.remove = function() {
                var what, a = arguments, L = a.length, ax;
                while (L && this.length) {
                    what = a[--L];
                    while ((ax = this.indexOf(what)) !== -1) {
                        this.splice(ax, 1);
                    }
                }
                return this;
            };                       
            for(let i = 1; i < this.menu[meal]; i++){
                this.productsInStock.remove(this.menu[meal][i]);
            }            
                this.budget += this.menu[meal][0];
        }else{
            console.log(`There is not ${meal} yet in our menu, do you want to order something else?`);
        }
    }
}
let kitchen = new Kitchen (1000);
console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

console.log(kitchen.showTheMenu());
kitchen.makeTheOrder('Pizza');