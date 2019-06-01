function solve(perfectNum, inputNums){
    let contains = false;
    inputNums.forEach((num) => {
        if(num === perfectNum){
            contains = true;
        }
    });
	if(contains){
		console.log('There is perfect num in array');
	}else{
		console.log('There is not perfect num in array');
	}
}
solve(5, [5, 6, 28]);
