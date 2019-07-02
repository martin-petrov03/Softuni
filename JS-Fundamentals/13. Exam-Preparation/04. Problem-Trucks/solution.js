function solve() {
    let buttons = document.querySelectorAll('button');
    let addNewTruckButton = buttons[0];
    addNewTruckButton.addEventListener('click', addTruck);
    let addNewTireButton = buttons[1];
    addNewTireButton.addEventListener('click', addTire);
    let goToWorkButton = buttons[2];
    goToWorkButton.addEventListener('click', goToWork);
    let endButton = buttons[3];
    endButton.addEventListener('click', end);
    
    let trucks = {};
    let backupTires = [];
    let countBackups = 0;
    function addTruck(){
        let plateNum = document.getElementsByTagName('input')[0].value;
        let tireCondition = document.getElementsByTagName('input')[1].value;
        if(!trucks[plateNum]){
            trucks[plateNum] = {
                'plateNum': plateNum,
                'tireCondition': tireCondition,
                'distance': 0,
            }
            console.log(trucks);     
        }
        let trucksElement = document.querySelector('section:nth-child(2) fieldset:nth-child(2) div');
        let divElement = document.createElement('div');
        divElement.textContent = plateNum;
        divElement.classList.value = 'truck';
        trucksElement.appendChild(divElement);
    }
    function addTire(){
        let tireStack = document.getElementsByTagName('input')[2].value;
        backupTires.push(tireStack);        
    }
    function goToWork(){
        let plateNum = document.getElementsByTagName('input')[3].value;
        let distance = +document.getElementsByTagName('input')[4].value;        
        if(trucks[plateNum].plateNum){
            let neededAmount = Math.floor(distance / 1000);
            let tireSum = 0;
            for (var key in trucks) {                
                if (!trucks.hasOwnProperty(key)) continue;
                if(key !== plateNum){
                    continue;
                }
                var obj = trucks[key];                
                for (var prop in obj) {
                    if(!obj.hasOwnProperty(prop)) continue;
                    if(prop === 'tireCondition'){
                        for(let i = 0; i < obj[prop].length; i++){
                            tireSum += Number(obj[prop][i]);
                        }                        
                    }
                }
            }
            console.log(tireSum + ' >= ' + neededAmount);
            if(tireSum >= neededAmount){
                for (var key in trucks) {                
                    if (!trucks.hasOwnProperty(key)) continue;
                    if(key !== plateNum){
                        continue;
                    }
                    var obj = trucks[key];                
                    for (var prop in obj) {
                        if(!obj.hasOwnProperty(prop)) continue;
                        if(prop === 'tireCondition'){
                            for(let i = 0; i < obj[prop].length; i++){
                                obj[prop][i] = Number(obj[prop][i]) - neededAmount;
                            }                        
                        }
                    }
                }                
                trucks[plateNum].distance += +distance;                         
            } else{
                if(backupTires.length > 0){
                    let backupTireSum = 0;
                    for(let i = 0; i < backupTires.length; i++){
                        backupTireSum += backupTires[i];
                    }
                    if(backupTireSum > tireSum && backupTireSum >= neededAmount){       countBackups++;
                        backupTireSum.splice(0, 1);
                        trucks.plateNum.distance += +distance;
                    }
                }
            }            
        }
    }
    function end(){
        let resultElement = document.querySelector('textarea');
        console.log(trucks);
        let tire = '';
                let num = '';
                let dis = 0;
        for (var key in trucks) {                
            if (!trucks.hasOwnProperty(key)) continue;
        
            var obj = trucks[key];
            for (var prop in obj) {
                if(!obj.hasOwnProperty(prop)) continue;
                
                /*if(prop === 'tireCondition'){
                    tire = obj[prop];
                }else */if(prop === 'plateNum'){
                    num = obj[prop];
                }else{
                    dis = obj[prop];
                }
                
            }
            resultElement.textContent += `Truck ${num} has traveled ${dis}.\n`;
            resultElement.textContent += `You have ${countBackups} sets of tires left.\n`;
        }
        /*
            */
    }    
}