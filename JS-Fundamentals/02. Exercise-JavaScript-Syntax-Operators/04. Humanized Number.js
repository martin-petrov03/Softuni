function solve(text){
    let arr = text.split(/[ ,.]+/);
    
    for(let item of arr){
        
        if(!isNaN(item)){
            if(Number(item) == 1 || Number(item) == -1){
                console.log(Number(item) + 'st');
                continue;
            } else if(Number(item) == 2 || Number(item) == -2){
                console.log(Number(item) + 'nd');
                continue;                
            } else if(Number(item) == 3){
                console.log(item + 'rd');
                continue;                
            } else{
                if(Number(item) != 0)
                console.log(Number(item) + 'th');
            }
        }        
    }
}
solve('Yesterday I bought 12. pounds of peppers, 3, kilograms of carrots and 5 kilograms of tomatoes.');