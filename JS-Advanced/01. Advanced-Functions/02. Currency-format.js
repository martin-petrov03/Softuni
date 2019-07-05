function solve(func){    
    function dollarFormater(value){     
        return func(",", "$", true, value);            
    }
    return dollarFormater;
}
solve(function currencyFormatter(separator, symbol, symbolFirst, value) {
    let result = Math.trunc(value) + separator;
    result += value.toFixed(2).substr(-2,2);
    if (symbolFirst) return symbol + ' ' + result;
    else return result + ' ' + symbol;
}
);