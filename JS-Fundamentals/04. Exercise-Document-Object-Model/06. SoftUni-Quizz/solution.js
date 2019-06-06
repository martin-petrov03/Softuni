function solve() {
	let buttons = document.getElementsByTagName('button');
	let sections = document.getElementsByTagName('section');
	buttons[0].addEventListener('click', firstQuestion);
	buttons[1].addEventListener('click', secondQuestion);
	buttons[2].addEventListener('click', thirdQuestion);
	let correctAnswers = 0;
	
	function firstQuestion(){
		if(document.querySelectorAll('#exercise  input[type=radio]')[2].checked && document.querySelectorAll('#exercise  input[type=radio]')[2].value === '2014'){
			correctAnswers++;			
		}
		sections[1].style.display = 'inline';
	}
	function secondQuestion(){
		if(document.querySelectorAll('#exercise  input[type=radio]')[6].checked && document.querySelectorAll('#exercise  input[type=radio]')[6].value === 'Pesho'){
			correctAnswers++;				
		}
		sections[2].style.display = 'inline-block';
	}
	function thirdQuestion(){
		if(document.querySelectorAll('#exercise  input[type=radio]')[11].checked && document.querySelectorAll('#exercise  input[type=radio]')[11].value === 'Nakov'){
			correctAnswers++;			
		}
		let resultDiv = document.getElementById('result');
		let pElement = document.createElement('p');
		pElement.style.color = 'green';
		if(correctAnswers === 3){
			pElement.textContent = 'You are recognized as top SoftUni fan!';
		}else{
			pElement.textContent = `You have ${correctAnswers} right answers`;
		}
		resultDiv.appendChild(pElement);
	}
}