function matrixSummer(matrix1, matrix2){
    let resultMatrix = [];

   for(let i = 0; i < Math.min(matrix1.length, matrix2.length); i++){
       let currentArr = [];
       let remainder = 0;

       for(let j = 0; j < Math.min(matrix1[i].length, matrix2[i].length); j++){
            let sum = matrix1[i][j] + matrix2[i][j];            
            if(sum + remainder > 9){
                while(sum > 9){
                    sum -= 9;
                    remainder++;
                }
                
                currentArr.push(9);
                
            }else{
                currentArr.push(sum + remainder);
                remainder = 0;
            }
       }       
       while(remainder > 0){
            currentArr.push(10 - remainder);
            remainder-=9;
       }
       resultMatrix.push(currentArr);    
   }
   console.log(JSON.stringify(resultMatrix));
}

/*matrixSummer(
    [[1, 2, 3], [3, 4, 5], [5, 6, 7]],
    [[1, 1, 1], [1, 1, 1], [1, 1, 1]]);

matrixSummer(
    [[9, 2, 3], [4, 5, 6], [7, 8, 8]],
    [[1, 1, 1], [1, 1, 1], [1, 1, 1]]);
*/
matrixSummer(
    [[9, 9, 9, 9, 9], [4, 7]],
    [[7, 1, 1, 1, 1], [1, 2]]);    