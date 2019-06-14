function solve() {
        let buttons = document.getElementsByTagName('button');              
        buttons[0].addEventListener('click', chop);
        buttons[1].addEventListener('click', dice);
        buttons[2].addEventListener('click', spice);
        buttons[3].addEventListener('click', bake);
        buttons[4].addEventListener('click', fillet);
    
        let resultPElement = document.getElementById('output');
        
        function chop(){
            let inputNum = document.querySelector('#exercise  input').value;
            if(inputNum == ''){
                inputNum = 0;
            }
            inputNum = Number(inputNum);
            let result = inputNum / 2;            
            resultPElement.textContent = result;        
        }
        function dice(){
            let inputNum = document.querySelector('#exercise  input').value;
            if(inputNum == ''){
                inputNum = 0;
            }
            inputNum = Number(inputNum);
            let result = Math.sqrt(inputNum, 2);            
            resultPElement.textContent = result;
        }
        function spice(){
            let inputNum = document.querySelector('#exercise  input').value;
            if(inputNum == ''){
                inputNum = 0;
            }
            inputNum = Number(inputNum);
            let result = inputNum + 1;            
            resultPElement.textContent = result;
        }
        function bake(){
            let inputNum = document.querySelector('#exercise  input').value;
            if(inputNum == ''){
                inputNum = 0;
            }
            inputNum = Number(inputNum);
            let result = inputNum * 3;            
            resultPElement.textContent = result;
        }
        function fillet(){
            let inputNum = document.querySelector('#exercise  input').value;
            if(inputNum == ''){
                inputNum = 0;
            }
            inputNum = Number(inputNum);
            let result = inputNum - 20/100*inputNum;            
            resultPElement.textContent = result;
        }
}