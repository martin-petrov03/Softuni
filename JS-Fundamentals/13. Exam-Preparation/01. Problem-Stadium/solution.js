function solve() {
    let buttons = document.getElementsByClassName('seat');
    Array.from(buttons).forEach((btn) => {
        btn.addEventListener('click', clickFunction);
    })
    let obj = {
        'Levski': {
            'A': 10,
            'B': 7,
            'C': 5
        },
        'Litex': {
            'A': 10,
            'B': 7,
            'C': 5
        },
        'VIP': {
            'A': 25,
            'B': 15,
            'C': 10
        },
        'summary': {
            'fans': 0,
            
        }
    };
    let resultArea = document.getElementById('output');
    let totalProfit = 0;
    function clickFunction(element){
        let seat = element.target;
        let zone = seat.parentNode.parentNode.parentNode.parentNode.parentNode.className;
        let sector = String.fromCharCode(65 + element.target.parentNode.cellIndex);        
        if(seat.style.backgroundColor === ''){
            seat.style.backgroundColor = 'rgb(255, 0, 0)';
            obj.summary.fans += 1;
            totalProfit += obj[zone][sector];
            resultArea.innerHTML += ` Seat ${seat.textContent} in zone ${zone} sector ${sector} was taken.\n`;
        }else{
            resultArea.innerHTML += ` Seat ${seat.textContent} in zone ${zone} sector ${sector} is unavailable.\n`;        
        }
    }    
    document.querySelector('#summary button').addEventListener('click', function (){
        document.querySelector('#summary span').innerHTML = `${totalProfit} leva, ${obj.summary.fans} fans.`;
    });
}