function solve(inputArr){
    let list = (function(){
        //closure
        let arr = [];
        
        function add(str){
            arr.push(str);
        }
        function remove(str){
            let newArr = [];
            for(let item of arr){
                if(item !== str){
                    newArr.push(item);
                }
            }
            arr = newArr;
        }
        function print(){
            console.log(arr.join(','));
        }
        return{add, remove, print};
    })();

    for(let element of inputArr){
        let line = element.split(' ');
        if(line[0] == 'add'){
            list.add(line[1]);
        }else if(line[0] == 'remove'){
            list.remove(line[1]);
        }else if(line[0] == 'print'){
            list.print();
        }
    }
}
solve(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print']);