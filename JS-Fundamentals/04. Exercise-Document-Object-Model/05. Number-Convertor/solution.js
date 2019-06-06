function solve() {
    let buttons = document.getElementsByTagName('button');
    let convertBtn = buttons[0];
    convertBtn.addEventListener('click', calculate);

    function calculate(){
        let dec_to_binary  = function(n, base) {
            if (n < 0) {
                n = 0xFFFFFFFF + n + 1;
            } 
            switch (base)  
            {  
                case 'B':
                return parseInt(n, 10).toString(2);
                break;  
                case 'H':  
                return parseInt(n, 10).toString(16);
                break;      
            }  
        }    
        let inputNum = document.getElementById('input').value;
        var dropDown = document.getElementById("selectMenuTo");    
        var str = dropDown.options[dropDown.selectedIndex].value;
        let resultInput = document.getElementById('result');
        if(str === 'binary'){
            let result = dec_to_binary(inputNum, 'B');
            console.log(result);
            resultInput.setAttribute("text", result);
        } else{
            let result = dec_to_binary(inputNum, 'H');
            resultInput.textContent = result;
        }
        
    }
}