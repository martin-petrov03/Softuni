document.getElementById("button").addEventListener("click", function(event){
    event.preventDefault()
});
function calculateRents() {
    let flatNums = document.getElementById('flats').value.split(', ');
    let families = document.getElementById('families').value.split(', ');
    let rents = document.getElementById('rents').value.split(', ');
    
    let result = [];
    let totalRent = 0;
    let resultElement = document.getElementById('result');
    for(let i = 0; i < flatNums.length; i++){
        let obj = {};
        obj['number'] = +flatNums[i];
        obj['family'] = families[i];
        obj['rent'] = +rents[i];
        totalRent += obj['rent'];
        result.push(obj); 
    }
        let output = '';
        for(let i = 0; i < result.length; i++){
            output = `In flat ${result[i]['number']} family ${result[i]['family']} has to pay ${result[i]['rent']}\n`;
            resultElement.innerHTML += output;
        }
        resultElement.innerHTML += `Total rent paid: ${totalRent}\n`;
}