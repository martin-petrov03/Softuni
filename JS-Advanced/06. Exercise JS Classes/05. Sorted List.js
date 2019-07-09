class List{
    constructor(){
        this.list = [];
        this.size = 0;
    }
    add(element){
        this.list.push(element);
        this.size++;
        this.sort();
    }
    remove(index){
        index = +index;
        if(index >= 0 && index < this.list.length){
            this.list.splice(index, 1);
            this.size--;
        }
    }
    get(index){
        if(index >= 0 && index < this.list.length){
            return this.list[index];
        }
    }
    sort(){
        return this.list.sort((a, b) => (a-b));
    } 
}
let arr = new List();
arr.add('Martin');
arr.remove(0);
arr.add('Misho');
arr.add('Adq');
arr.add('Viki');
console.log(arr.list);
arr.remove(0);
console.log(arr.get(0));
console.log(arr.size);