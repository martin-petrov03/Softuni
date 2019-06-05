function solve() {
	let buttons = document.getElementsByTagName('button');
	let textAreas = document.getElementsByTagName('textarea');	

	buttons[0].addEventListener('click', encode);
	buttons[1].addEventListener('click', decode);

	function encode(){
		let encodeMessage = textAreas[0].value;
		let newStr = '';
		for(let i = 0; i < encodeMessage.length; i++){
			let currentCharCode = encodeMessage.charCodeAt(i);						
			newStr += String.fromCharCode(currentCharCode + 1);
		}		
		textAreas[0].value = '';
		textAreas[1].value = newStr;
	}
	function decode(){
		let decodeMessage = textAreas[1].value;
		let encodeStr = '';
		for(let i = 0; i < decodeMessage.length; i++){
			let currentCharCode = decodeMessage.charCodeAt(i);						
			encodeStr += String.fromCharCode(currentCharCode - 1);
		}		
		textAreas[0].value = encodeStr;
		textAreas[1].value = '';
	}
}