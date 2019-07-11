function solve(obj){
    let modifiedObj = Object.create(obj);
    modifiedObj.weight = modifiedObj.weight;
    modifiedObj.experience = modifiedObj.experience;
    
    if(modifiedObj.handsShaking === false){
        modifiedObj.bloodAlcoholLevel = modifiedObj.bloodAlcoholLevel;
        modifiedObj.handsShaking = modifiedObj.handsShaking;
    }else{
        modifiedObj.bloodAlcoholLevel += 0.1 * modifiedObj.weight * modifiedObj.experience;
        modifiedObj.handsShaking = false;
    }
    return modifiedObj;
}
solve({ weight: 80,
    experience: 1,
    bloodAlcoholLevel: 0,
    handsShaking: true }
  );
  solve({ weight: 120,
    experience: 20,
    bloodAlcoholLevel: 200,
    handsShaking: true }
  );
  solve({ weight: 95,
    experience: 3,
    bloodAlcoholLevel: 0,
    handsShaking: false }
  );
  solve({ weight: 95,
    experience: 3,
    bloodAlcoholLevel: 0,
    handsShaking: false });