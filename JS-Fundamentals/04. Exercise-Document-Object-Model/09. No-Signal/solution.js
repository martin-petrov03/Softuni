function solve() {
	let divEl = document.getElementById('exercise');
	for(let i = 0; i < 10; i++){
		divEl.style.verticalAlign = Math.random(1, 45);
		divEl.style.marginTop = Math.random(1/100, 81/100);
	}
}