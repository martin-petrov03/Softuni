function attachEvents() {
	$('#items li').click(selectAndAddLi);
	$('#showTownsButton').click(showTowns);
	let towns = [];
	function selectAndAddLi(){			
		if($(this).attr('data-selected') == 'true'){		
			towns.splice(towns.indexOf($(this).text()), 1);
			$(this).css('background-color', '');
			$(this).attr('data-selected', 'false');
		}else{
			$(this).attr('data-selected', 'true');
			$(this).css('background-color', '#BBB');
			towns.push($(this).text());
		}
	}
	function showTowns(){
		$('#selectedTowns').text(towns.join(', '));
	}
}