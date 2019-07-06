let manager = (function (){
    let ingredientObj = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };
    let recipesObj = {
        apple: {            
            carbohydrate: 1,
            flavour: 2,            
        },
        coke:{           
            carbohydrate: 10,          
            flavour: 20,            
        },
        burger:{            
            carbohydrate: 5,
            fat: 7,
            flavour: 3
        },
        omelet:{           
            protein: 5,
            fat: 1,
            flavour: 1
        },
        cheverme:{
            protein: 10,
            carbohydrate: 10,
            fat: 10,
            flavour: 10
        }
    };
    const prepareRecipe = (recipe, neededQuantity) => {
        const neededIngredients = Object.entries(recipesObj[recipe]);
        for(let [ing, qty] of neededIngredients){
            const ingredientNeeded = ingredientObj[ing] * neededQuantity;
            if(qty > ingredientNeeded){
                return 'Error: not enough ' + ing + ' in stock';
            }
        }
        for(let [ing, qty] of neededIngredients){
            ingredientObj[ing] -= neededQuantity * qty;
            return 'Success';
        }
    }
    return function(input){
        let inputArr = input.split(' ');
        let command = inputArr[0];
        switch(command){
            case 'restock':
                let element = inputArr[1];
                let quantityEl = inputArr[2];

                ingredientObj[element] += quantityEl;
                return 'Success';            
            case 'prepare':
                let recipe = inputArr[1];
                let quantity = +inputArr[2];
                return prepareRecipe(recipe, quantity);            
            case 'report':                
                return Object.entries(ingredientObj).map((str) => `${str[0]}=${str[1]}`).join(' ');
        }               
    }
})()
console.log(manager('restock carbohydrate 10'));
//ingredient - съставна част