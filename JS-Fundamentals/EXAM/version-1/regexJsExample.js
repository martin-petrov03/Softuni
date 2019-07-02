function solve(arr){
    //let reg = /<([a-z1-9]+)>([A-Z1-9a-z!?., '"()*/\-+.\\/`]+)<\/\1>[ a-zA-Z1-9]+/gm;    
    let globalRegex = /<([a-z0-9]+)>(.*)<\/\1>/yg;
    let output = [];
    for(let text of arr){
        let allMatch = text.match(globalRegex);
        
        if(allMatch == text){
            let currentLine = '';       
            for(let i = 0; i < text.length; i++){
                if(text[i] === '<'){i++;
                    let isChar = false;
                    if(text[i] == '/'){
                        i++;
                        isChar = true;
                    }
                    if(/[a-z]/gm.test(text[i])){
                        for(let j = i; ;j++){
                            if(text[j] == '>'){
                                i = j;
                                break;
                            }
                        }
                    }else{
                        currentLine += '<';
                        if(isChar){
                            currentLine += '/';
                        }                        
                        currentLine += text[i];                        
                    }
                }else{
                    currentLine += text[i];
                }
            }

            output.push(currentLine);
        }
    }
    console.log(output.join(' '));
}

solve(['<h1><span>Hello World!</span></h1>',
'<p>I am Peter.']);