function solve(arr){
    prices = [];
    for(let i = 0; i < arr.length; i++){
        let itemsArr = arr[i].split(', ');
        let price = 0;

        let coinsInserted = Number(itemsArr[0]);
        let drinkType = itemsArr[1];
        if(drinkType === "coffee"){
            let coffeeType = itemsArr[2];
            if (coffeeType === "caffeine"){
                price = 0.80;                
            } else if (coffeeType === "decaf"){
                price = 0.90;
            }           
        } else if(drinkType === "tea"){
            price = 0.8;
        }
        let containsMilk = false;
        if(itemsArr.includes('milk')){         
            increase = Number((0.1 * price).toFixed(1));
            price += 0.1;
            //console.log(increase);
            containsMilk = true;
        }
        if(containsMilk){
            let sugarQuantity = Number(itemsArr[4]);
            if(sugarQuantity > 0 && sugarQuantity <= 5){
                price += 0.1;
            }
        }else{
            let sugarQuantity = Number(itemsArr[3]);
            if(sugarQuantity > 0 && sugarQuantity <= 5){
                price += 0.1;
            }
        }
      
        if(coinsInserted >= price){
            console.log(`You ordered ${drinkType}. Price: ${price.toFixed(2)}$ Change: ${(coinsInserted - price).toFixed(2)}$`);
            prices.push(price);
        } else{
            console.log(`Not enough money for ${drinkType}. Need ${(price - coinsInserted).toFixed(2)}$ more.`);
        }
        
        //console.log(itemsArr);
    }
    function sum(array) {
        for (
          var
            index = 0,              // The iterator
            length = array.length,  // Cache the array length
            sum = 0;                // The total amount
            index < length;         // The "for"-loop condition
            sum += array[index++]   // Add number on each iteration
        );
        return sum;
      }
    console.log('Income Report: ' + sum(prices).toFixed(2) + '$');
}
solve([
    '0.4, tea, milk, 4'
]);