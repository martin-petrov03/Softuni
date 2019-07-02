function solve(inputArr){
    let outputArr = [];
    for(let i = 1; i < inputArr.length; i++){		
        let name = inputArr[i][0];
        let age = inputArr[i][1];
		let grade = inputArr[i][2];
		outputArr.push([name, age, grade]);        
	}	
	outputArr.forEach((arr) => {
		console.log(arr.join(' | '));
	});
}
solve([['name', 'age', 'grade'],
['Peter', '25', '5.00'],
['George', '34', '6.00'],
['Marry', '28', '5.49']]
);
