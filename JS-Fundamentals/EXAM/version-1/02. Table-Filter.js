function solve(inputArr, sort){
    let outputArr = [];
    for(let arr of inputArr){
        outputArr = [];
        for(let element of arr){
            outputArr.push(element);
        }
        console.log(outputArr.join(' | '));
    }
}
solve([['name', 'age', 'grade'],
['Peter', '25', '5.00'],
['George', '34', '6.00'],
['Marry', '28', '5.49']],
'sort name'
);