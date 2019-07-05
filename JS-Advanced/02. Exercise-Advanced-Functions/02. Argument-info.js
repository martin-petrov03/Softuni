function solve(){
    let strsCount = 0;
    //let objsCount = 0;
    let numsCount = 0;
    let functionsCount = 0;
    for(let el of arguments){
        let type = typeof(el);
        console.log(`${type}: ${el}`);
        if(type === 'string'){
            strsCount++;
        }else if(type === 'number'){
            numsCount++;
        }else if(type === 'function'){
            functionsCount++;
        }/*else if(type === 'object'){
            objsCount++;
        }*/
    }
    if(strsCount > 0){
        console.log(`string = ${strsCount}`);
    }
    if(numsCount > 0){
        console.log(`number = ${numsCount}`);
    }
    if(functionsCount > 0){
        console.log(`function = ${functionsCount}`);
    }
    /*if(objsCount > 0){
        console.log(`object = ${objsCount}`);
    }*/
}
solve('cat', 42, function () { console.log('Hello world!'); });