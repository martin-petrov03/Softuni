function validate() {
    let buttons = document.getElementsByTagName('buttons');
    let inputNum = document.querySelector('#exercise > input').value; 
    buttons[0].addEventListener('click', chop);
    buttons[1].addEventListener('click', dice);
    buttons[2].addEventListener('click', spice);
    buttons[3].addEventListener('click', bake);
    buttons[4].addEventListener('click', fillet);

    let resultPElement = document.getElementById('output');
    console.log(resultPElement);
    if(inputNum === ''){
        inputNum = Number(0);
    } else{
        inputNum = Number(inputNum);
    }
    function chop(){
        resultPElement.textContent = inputNum / 2;
    }
}