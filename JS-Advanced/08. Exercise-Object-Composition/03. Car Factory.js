function solve(obj){
    let modifiedObj = Object.create(obj);
    modifiedObj.model = modifiedObj.model;

    modifiedObj.engine = {};        
    //define engine type
    if(modifiedObj.power <= 90){
        modifiedObj.engine.power = 90;
        modifiedObj.engine.volume = 1800;
    }else if(modifiedObj.power <= 120){
        modifiedObj.engine.power = 120;
        modifiedObj.engine.volume = 2400;
    }else if(modifiedObj.power <= 200){
        modifiedObj.engine.power = 200;
        modifiedObj.engine.volume = 3500;
    }

    //define carriage
    let typeCarrige = modifiedObj.carriage;
    modifiedObj.carriage = {};
    modifiedObj.carriage.type = typeCarrige;
    modifiedObj.carriage.color = modifiedObj.color;

    //define wheels
    modifiedObj.wheels = {};
    let wheelsSize = 0;
    for(let i = modifiedObj.wheelsize; i >= 0; i--){
        if(i % 2 == 1){
            wheelsSize = i;
            break;
        }
    }    
    modifiedObj.wheels = [];
    for(let i = 1; i <= 4; i++){
        modifiedObj.wheels.push(wheelsSize);
    }    
    return modifiedObj;
}
solve({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
);
solve({ model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }
);