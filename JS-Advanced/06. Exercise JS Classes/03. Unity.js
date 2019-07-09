class Rat{
    constructor(name){
        this.name = name;
        this.rats = [];
        this.unitedRats = [];
    }
    toString(){
        let output = `${this.name}\n`;
        for(let rat of this.unitedRats){
            output += `##${rat.name}\n`;
        }
        return output;
    }
    getRats(){
        return this.unitedRats;
    }
    unite(otherRat){
        if(otherRat instanceof Rat){
            this.unitedRats.push(otherRat.name);
            return this.unitedRats;
        }        
    }
}
let test = new Rat("Pesho");
test.unite(new Rat("Gosho"));
test.unite(new Rat("Sasho"));
console.log(test.getRats());
//[ Rat { name: 'Gosho', unitedRats: [] },
//  Rat { name: 'Sasho', unitedRats: [] } ]
