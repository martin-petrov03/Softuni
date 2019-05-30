function solve(leftOperand, rightOperand, operator){
    rightOperand = Number(rightOperand);
    leftOperand = Number(leftOperand);
    switch(operator){
        case '+': console.log(leftOperand + rightOperand);
            break;
        case '-': console.log(leftOperand - rightOperand);
            break;
        case '*': console.log(leftOperand * rightOperand);
            break;
        case '/': console.log(leftOperand / rightOperand);
            break;
        case '%': console.log(leftOperand % rightOperand);
            break;
        case '**': console.log(leftOperand ** rightOperand);
            break;            
    }
}
solve('5', '6', '+');