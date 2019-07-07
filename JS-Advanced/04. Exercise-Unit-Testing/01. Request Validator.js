function validateRequest(obj){    
    if(validation(obj) === true){
        console.log(obj);
    }        
}
function validation(obj){
    const uriRegex = /^([\w.]+)$/gm;
    const messageRegex = /^([^<>\\&'"]+)&/gm;
    let isMethodValid = false;
    let isURIValid = false;
    let isVersionValid = false;
    let isMessageValid = false;
    
    if(obj.hasOwnProperty('method')){
        isMethodValid = methodValidation(obj);
        if(!isMethodValid){
            printError('Method');
        }
    }else{
        printError('Method');
    }
    if(obj.hasOwnProperty('uri')){
        isURIValid = uriValidation(obj);
        if(!isURIValid){
            printError('URI');
        }
    }else{
        printError('URI');
    }
    if(obj.hasOwnProperty('version')){
        isVersionValid = versionValidation(obj);
        if(!isVersionValid){
            printError('Version');
        }
    }else{
        printError('Version');
    }
    if(obj.hasOwnProperty('message')){
        isMessageValid = messageValidation(obj);
        if(!isMessageValid){
            printError('Message');
        }
    }else{
        printError('Message');
    }
    
    function printError(invalid){
        //throw Error(`Invalid request header: Invalid ${invalid}!`);
        console.log(`Invalid request header: Invalid ${invalid}!`);
    }
    function methodValidation(obj){
        let isMethodValid = false;
        if(obj.hasOwnProperty('method')){
            if(obj.method === 'GET' ||
            obj.method === 'POST' ||
            obj.method === 'DELETE' ||
            obj.method === 'CONNECT'){                    
                isMethodValid = true;
            }
        }
        return isMethodValid;
    }
    function uriValidation(obj){
        let isURIValid = false;
        if(obj.hasOwnProperty('uri')){
            if(obj.uri === '*' || uriRegex.test(obj.uri)){
                isURIValid = true;
            }
        }
        return isURIValid;  
    }
    function versionValidation(obj){
        let isVersionValid = false;
        if(obj.hasOwnProperty('version')){
            if(obj.version === 'HTTP/0.9' ||
                obj.version === 'HTTP/1.0' ||
                obj.version === 'HTTP/1.1' ||
                obj.version === 'HTTP/2.0'){
                    isVersionValid = true;
            }
        }
        return isVersionValid;
    }
    function messageValidation(obj){
        let isMessageValid = false;
        if(obj.hasOwnProperty('message')){
            if(messageRegex.test(obj.message) || obj.message == ''){
                isMessageValid = true;
            }
        }
        return isMessageValid;
    }

    if(isMethodValid && isURIValid && isVersionValid && isMessageValid){            
        return true;
    }else{
        return false;
    }
}
console.log(validateRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
  }));
  