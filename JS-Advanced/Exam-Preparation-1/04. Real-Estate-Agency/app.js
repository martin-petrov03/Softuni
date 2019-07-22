function realEstateAgency () {
	$('button[name=regOffer]').click(validation);
	$('button[name=findOffer]').click(findHome);

	let homes = [];
	function validation(){		
		let rentPrice = $('#regOffer input')[0].value;
		let apartamentType = $('#regOffer input')[1].value;
		let commissionRate = $('#regOffer input')[2].value;		

		let isValid = false;
		let output = '';

		if(!isNaN(rentPrice) && rentPrice > 0 ){
			if(!isNaN(commissionRate) && commissionRate >= 0 && commissionRate <= 100){
				if(apartamentType !== ''){
					let apartamentTypeArr = apartamentType.split('');
					if(apartamentTypeArr.indexOf(':') == -1){
						isValid = true;
					}
				}
			}			
		}
		if(isValid){
			output = 'Your offer was created successfully.';
			let $flatDiv = $('#building');
			let $apartament = $('<div>');
			$apartament.attr('class', 'apartment');
			let p1 = $('<p>').text(`Rent: ${rentPrice}`);
			let p2 = $('<p>').text(`Type: ${apartamentType}`);
			let p3 = $('<p>').text(`Commission: ${commissionRate}`);
			$apartament.append(p1);
			$apartament.append(p2);
			$apartament.append(p3);
			$flatDiv.append($apartament);
			let obj = {
				'Rent': rentPrice,
				'Type':apartamentType,
				'Commission': commissionRate
			};
			homes.push(obj);			
		}else{
			output = 'Your offer registration went wrong, try again.';
		}
		$('#message').text(output);
		rentPrice = '';
		apartamentType = '';
		commissionRate = '';
	}
	function findHome(){
		let familyBudget = +$('input[name=familyBudget]').val();
		let apartamentType = $('input[name=familyApartmentType]').val();
		let familyName = $('input[name=familyName]').val();

		//validate
		if(familyBudget > 0 && apartamentType !== '' && familyName !== ''){
			let index = -1;
			for(let home of homes){
				index++;
				let $currentFlat = $(`.apartment:nth-child(${index+1})`);
				
				if(apartamentType === home.Type){
					let finalPrice = +home.Rent + 
					(+home.Rent * +home.Commission) / 100;
					if(finalPrice <= familyBudget){
						isValid = true;
						
						let $moveOutBtn = $('<button>');
						$moveOutBtn.text('MoveOut');
						
						$moveOutBtn.click(function(){
							homes.splice(index, 1);
							$currentFlat.remove();

							$('#message').text(`They had found cockroaches in ${familyName}\'s apartment`);
						});
						$currentFlat.append($moveOutBtn);
						$('#message').text('Enjoy your new home! :))');
						$currentFlat.css('border', '2px solid red');

						let previousProfit = +$('#roof h1').text().split(' ')[2];
						$('#roof h1').text(`Agency profit: ${previousProfit + 0.5 * finalPrice} lv.`);
						return;
					}
				}
				if(!isValid){
					$('#message').text('We were unable to find you a home, so sorry :(');
				}
			}			
		}
		$('input[name=familyName]').val('');
		$('input[name=familyApartmentType]').val('');
		$('input[name=familyBudget]').val('');
	}
}