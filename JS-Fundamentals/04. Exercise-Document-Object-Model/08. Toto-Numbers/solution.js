function solve() {
	let buttons = document.getElementsByTagName('button');
	
	buttons[0].addEventListener('click', getNums);
	function getNums(){
		let getNumsElement = document.querySelector('#myNumbers input').value;
		getNumsElement = getNumsElement.split(' ');
		console.log(getNumsElement);
		for(let i = 0; i < getNumsElement.length; i++){
			let divElement = document.getElementById('allNumbers');			
			divElement.display = 'inline-block';
			for(let j = 1; j < 50; j++){
				let divCurrentEl = document.createElement('div');
				if(j === Number(getNumsElement[i])){
					let pEl = document.createElement('p');
					pEl.textContent = j;
					var att = document.createAttribute("class");
					att.value = "numbers";
					pEl.style.display = 'inline-block';
					divCurrentEl.style.display = 10;
					pEl.style.marginRight = 5;
					divCurrentEl.style.marginRight = '2px';
					divCurrentEl.style.float = 'rigth';
					divCurrentEl.style.backgroundColor = 'orange';
					divCurrentEl.style.display = 'inline-block';			
					divCurrentEl.appendChild(pEl);					
					divElement.appendChild(divCurrentEl);
				}else{
					let pEl = document.createElement('p');
					pEl.textContent = j;
					pEl.style.display = 'inline-block';
					divCurrentEl.style.marginRight = 5;					
					divCurrentEl.style.display = 10;
					divCurrentEl.style.float = 'rigth';					
					divCurrentEl.style.display = 'inline-block';
					divCurrentEl.appendChild(pEl);
					divElement.appendChild(divCurrentEl);
				}				
			}
		}
	}
}