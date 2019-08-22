function dart(){
	let scores = {
		green: 0,
		yellow: 0,
		orange: 0,
		red: 0,
		purple: 0,
		blue: 0
	};

	//keep the result
	let homeScores = +$('#Home p:first-child').text();
	let guestScores = +$('#Away p:first-child').text();

	//get scores
	$('#scoreBoard table tbody tr').each(function() {
		let score = $(this).find("td:odd").text().split(' ');
		let color = $(this).find("td:even").text().toLowerCase();		
		let currentScore = score[0];		
		scores[color] = +currentScore;
	 });
	
	$('#playBoard').on('click', 'div', clickOnPlayBoard);
	function clickOnPlayBoard(event){
		event.stopPropagation();
		
		let score = 0;
		if(event.target.id == 'firstLayer'){
			score = scores.green;
		}else if(event.target.id == 'secondLayer'){
			score = scores.yellow;
		}else if(event.target.id == 'thirdLayer'){
			score = scores.orange;
		}else if(event.target.id == 'fourthLayer'){
			score = scores.red;
		}
		else if(event.target.id == 'fifthLayer'){
			score = scores.purple;
		}
		else if(event.target.id == 'sixthLayer'){
			score = scores.blue;
		}
		console.log(score);
		applyScore(score);
	}
	let isHome = true;
	function applyScore(score){
		if(isHome){
			homeScores += score;
			if(homeScores < 100){
				$('#Home p:first-child').text(homeScores);
				isHome = false;
			}else{
				//home wins
				$('#Home p:nth-child(2)').css('background-color', 'green');
				$('#Away p:nth-child(2)').css('background-color', 'red');
				//console.log('Home wins');				
			}
			$('#turns p:first-child').text('Turn on Away');
			$('#turns p:nth-child(2)').text('Next is Home');			
		}else{
			guestScores += score;
			if(guestScores < 100){
				$('#Away p:first-child').text(guestScores);			
				isHome = true;
			}else{
				//Away wins
				//console.log('Away wins');
				$('#Home p:nth-child(2)').css('background-color', 'red');
				$('#Away p:nth-child(2)').css('background-color', 'green');
			}
			$('#turns p:first-child').text('Turn on Home');
			$('#turns p:nth-child(2)').text('Next is Away');
		}		
	}
}