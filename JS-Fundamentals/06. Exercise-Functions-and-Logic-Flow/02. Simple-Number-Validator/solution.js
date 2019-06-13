document.querySelector('#check').addEventListener("click", validate);
function validate() {
	console.log('12');
    const num = +document.querySelector('#input').value;
    let message = '';
    if(num < 0){
    	message = 'Negative Number';
    } else if(num === 0){
    	message = "Zero";
    } else if(num > 0){
    	message = "Positive Number";
    }else{
    	message = "Invalid Input";
    }
    message += '!';
    document.querySelector('#response').textContent = message;
}