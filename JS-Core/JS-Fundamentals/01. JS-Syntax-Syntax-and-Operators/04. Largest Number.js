function solve(num1, num2, num3){
    num1 = Number(num1);
    num2 = Number(num2);
    num3 = Number(num3);
    console.log(`The largest number is ${Math.max(Math.max(num1, num2), num3)}.`);
}
solve('-3', '5', '16');