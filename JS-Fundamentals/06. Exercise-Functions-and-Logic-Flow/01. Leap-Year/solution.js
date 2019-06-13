function leapYear() {    
    let button = document.querySelector('#exercise button');    
    button.addEventListener('click', checkTheYear);
    function checkTheYear(){        
        document.querySelector('#year h2').textContent = '';
        document.querySelector('#year div').innerHTML = '';
        let year = document.querySelector('#exercise > input').value;
        function isLeap(year){
            return (year & 3) == 0 && ((year % 25) != 0 || (year & 15) == 0);
        }
        let resultH2Element = document.querySelector('#year h2');
        let resultDivResult = document.querySelector('#year div');
        if(isLeap(year)){
            resultH2Element.textContent = 'Leap Year';
            let pElement = document.createElement('p');
            pElement.textContent = year;
            resultDivResult.appendChild(pElement);
        }else {
            resultH2Element.textContent = 'Not Leap Year';
            let pElement = document.createElement('p');
            pElement.textContent = year;
            resultDivResult.appendChild(pElement);
        }        
        document.querySelector('#exercise > input').value = '';
    }
}