function autoService(input){
    let carsParts = [];
    let instructions = [];
    for(let i = 0; i < input.length; i++){
        let command = input[i].split(' ');
        if(command[0] == 'addPart'){            
            let arr = [
                ['brandName', command[1]],
                [command[2], command[3]]
            ];                          
            carsParts.push(arr);
        }else if(command[0] == 'instructions'){
            if(!instructions.includes(command[1])){
                instructions.push(command[1]);
            }            
        }else if(command[0] == 'repair'){
            let carBrand = command[1];
            if(instructions.includes(carBrand)){
                let brokenPart = '';            
                command[2] = JSON.parse(command[2]);
                let output = `${carBrand} client - {`;       
                Object.entries(command[2]).forEach((rep) => {
                    let i = 0;
                    carsParts.forEach((carPart) => {
                        if(carPart[0][1] == carBrand){
                            if(carPart[1][0] == rep[0]){
                                if(rep[1] === 'broken'){
                                    rep[1] = carPart[1][1];
                                    carsParts.splice(i, 1);
                                    
                                    if(output == `${carBrand} client - {`){
                                        if(!output.includes(`"${carPart[1][0]}": "${carPart[1][1]}"`)){
                                            output += `"${carPart[1][0]}": "${carPart[1][1]}"`;
                                        }
                                    }else{
                                        if(!output.includes(`"${carPart[1][0]}": "${rep[1]}"`)){
                                            output += `, "${carPart[1][0]}": "${rep[1]}"`;
                                        }
                                    } 
                                }else{                                    
                                    if(output == `${carBrand} client - {`){
                                       if(!output.includes(`"${carPart[1][0]}": "${carPart[1][1]}"`)){
                                            output += `"${carPart[1][0]}": "${carPart[1][1]}"`;
                                        }
                                    }else{
                                        if(!output.includes(`"${carPart[1][0]}": "${rep[1]}"`)){
                                            output += `, "${carPart[1][0]}": "${rep[1]}"`;
                                        }
                                    } 
                                }             
                            }                            
                        }
                        i++;
                    });                                                   
                });
                if(output !== '${carBrand} client - {'){
                    console.log(output + '}');
                }            
            }else{
                console.log(`${carBrand} is not supported`);
            }
        }
    }
    //console.log(carsParts);
    //console.log(instructions);
}

autoService(
    [
        'instructions bmw',    
        'addPart opel engine GV1399SSS',
        'addPart opel transmission SMF556SRG',
        'addPart bmw engine GV1399SSS',   
        'addPart bmw transmission SMF444ORG',
        'addPart opel transmission SMF444ORG',
        'instructions opel',
        'repair opel {"engine":"broken","transmission":"OP8766TRS"}',
          'repair bmw {"engine":"ENG999FPH","transmission":"broken","wheels":"broken"}'
      ]        
);
//'repair bmw {"engine":"ENG999FPH","transmission":"broken","wheels":"broken"}'



/* if(rep[0] === 'engine' && rep[1] == 'broken'){
                        
                        carsParts.forEach((part) => {
                            if(part[0][1] === carBrand){
                                if(part[1][0] === 'engine'){
                                    //command[2]['engine'] = part[1][1];
                                    console.log(`${carBrand} client - "engine": "${part[1][1]}","transmission": "${command[2]['transmission']}"}`);
                                    carsParts.remove( [ [ 'brandName', carBrand ], ['engine', part[1][1] ]] );
                                    carsParts.forEach((a) => {
                                    console.log(a == [ [ 'brandName', carBrand ], ['engine', part[1][1] ] ]);
                                    });
                                }else{
                                    //command[2]['transmission'] = part[1][1];
                                    console.log(`${carBrand} client - "engine": "${command[2]['engine']}","transmission": "${part[1][1]}"}`);
                                }                     
                                
                            }
                        });
                    } */