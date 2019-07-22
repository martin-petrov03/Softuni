class Vacation{
    
    constructor(organizer, destination, budget){
        this.organizer = organizer;
        this.destination = destination;
        this.budget = budget;
        this.kids = {};
        this.names = [];
    }
    registerChild(name, grade, currentBudget){        
        function contains(arr, element) {
            for (let i = 0; i < arr.length; i++) {               
                if (arr[i] === element) {
                    return true;
                }
            }
            return false;
        }
                        
        if(contains(this.names, name)){         
            return `${name} is already in the list for this ${this.destination} vacation.`;
        }else{
            if(this.budget <= currentBudget){
                if(!this.kids.hasOwnProperty(grade)){
                    this.kids[grade] = [];
                }              
                this.kids[grade].push(`${name}-${currentBudget}`);
                
                return this.kids;
            }else{
                return `${name}'s money is not enough to go on vacation to ${this.destination}.`;
            }  
        }  
    }

    removeChild(name, grade){
        console.log(name);
        let values = [];        
        function getNames(obj, element) {
            for (let [key, value] of Object.entries(obj)){
                values.push(value[0].split('-')[0]);
            }
            
        }
        getNames(this.kids, name);        
        let isContains =  values.indexOf(name) >= 0;

        if(isContains && this.kids.hasOwnProperty(grade)){            
            values.splice(values.indexOf(name), 1);

            let newObj = {};
            for (let [key, value] of Object.entries(this.kids)){
                let name = '';                
                if(this.kids[grade].length == 1){
                    name = this.kids[grade][0].split('-')[0];
                }                
                if(value[0].split('-')[0] !== name){
                    newObj[grade] = value;
                }
                this.kids = newObj;
                return this.kids;
            }
            
        }else{
            return `We couldn't find ${name} in ${grade} grade.`;
        }
    }
     toString(){             
         if(Object.keys(this.kids).length > 0){
            let output = `${this.organizer} will take ${Object.entries(this.kids).length} children on trip to ${this.destination}\n`; 
            

            for (let [key, value] of Object.entries(this.kids)) {
                output += 'Grade:' + key + '\n';
                
                for(let i = 0; i < this.kids[key].length; i++){
                    output += `${i + 1}. ${this.kids[key][i]}\n`;
                }
                output += '\n';
            }
            return output;
         }else{
             return `No children are enrolled for the trip and the organization of ${this.organizer} falls out...`;             
         }
     }
     numberOfChildren(){
         let length = 0;
        for (let [key, value] of Object.entries(this.kids)) {
            length += value.length;
        }
        return length;
     }
}
let vacation = new Vacation('Miss Elizabeth', 'Dubai', 2000);

vacation.registerChild('Gosho', 5, 3000);
vacation.registerChild('Lilly', 6, 1500);
vacation.registerChild('Pesho', 7, 4000);
vacation.registerChild('Tanya', 5, 5000);
vacation.registerChild('Mitko', 10, 5500);

console.log(vacation.toString());
console.log(vacation.numberOfChildren());