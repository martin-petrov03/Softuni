function calculate(amount, vat){    
    let resultAmount = amount / (vat / 100 + 1);
    console.log(resultAmount.toFixed(2));
}

calculate(220.00, 10.00);