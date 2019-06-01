function solve(amount, arrWithCoins){
    amount = Number(amount);
    arrWithCoins.sort((a, b) => a < b);
    usedCoins = [];
    for(let i = 0; i < arrWithCoins.length; i++){
        while(amount >= arrWithCoins[i]){
            amount -= arrWithCoins[i];
            usedCoins.push(arrWithCoins[i]);
        }
    }
    console.log(usedCoins.join(', '));
}
solve(46, [10, 25, 5 , 1, 2]);