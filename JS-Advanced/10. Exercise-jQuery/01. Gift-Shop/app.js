function solution() {
	let isThereDiv;
	let addButton = document.getElementsByTagName('button')[0].addEventListener('click', addProduct);
	function addProduct(){	
		let toyType = $('#toyType').val();
		let toyPrice = $('#toyPrice').val();
		let toyDescription = $('#toyDescription').val();
	
		//validate
		if(toyType !== '' && !isNaN(toyPrice) && toyDescription.length >= 50){
			let divElement = $('<div>');
			divElement.addClass('gift');
			let imgElement = $('<img>');
			imgElement.attr('src', 'gift.png');
			let headline = $('<h2>');
			headline.text(toyType);
			let pElement = $('<p>');
			pElement.text(toyDescription);
			let button = $('<button>');
			button.text(`Buy it for $${toyPrice}`);
	
			button.click(function(){
				divElement.remove();		
			});
	
			divElement.append(imgElement);
			divElement.append(headline);
			divElement.append(pElement);
			divElement.append(button);
			$('#christmasGiftShop').append(divElement);
			isThereDiv = true;
			document.getElementById('toyType').value = '';
			document.getElementById('toyPrice').value = '';
			document.getElementById('toyDescription').value = '';
		}	
	}
		
	}