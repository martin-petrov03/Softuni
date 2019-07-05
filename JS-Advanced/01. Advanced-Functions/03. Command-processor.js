function solve(arr){
    function append(str){
        globalString += str;
    }
    function removeFromStart(count){
        let reducedStr = '';
        for(let i = 0; i < globalString.length; i++){
            if(count <= i){
                reducedStr += globalString[i];
            }
        }
        return reducedStr;
    }    
    let globalString = '';
    for (let command of arr){
        let commandArr = command.split(' ');
        if(commandArr[0] === 'append'){
            append(commandArr[1]);            
        }else if(commandArr[0] === 'removeStart'){
            globalString = removeFromStart(commandArr[1]);        
        }else if(commandArr[0] === 'removeEnd'){          
            globalString = globalString.substring(0, globalString.length-commandArr[1]);
        }else if(commandArr[0] === 'print'){
            console.log(globalString);
        }
    }
}
solve(['append hello',
'append again',
'removeStart 3',
'removeEnd 4',
'print']
);