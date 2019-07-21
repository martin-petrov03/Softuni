function acceptance() {
	let companyName = document.getElementsByTagName('input')[0].value;
	let productName = document.getElementsByTagName('input')[1].value;
	let productQuantity = +document.getElementsByTagName('input')[2].value;
	let productScrape = +document.getElementsByTagName('input')[3].value;

	if((companyName !== '' && productName !== '' && !isNaN(productQuantity) && !isNaN(productScrape))){		
		productQuantity = productQuantity - productScrape;
		if(productQuantity <= 0){return;}
		

		let $div = $('<div>');
		let $pElement = $('<p>');
		$pElement.text(`[${companyName}] ${productName} - ${productQuantity} pieces`);

		let $btn = $('<button>');
		$btn.attr('type', 'button');
		$btn.text('Out of stock');
		$div.append($pElement);
		$div.append($btn);

		$('#warehouse').append($div);

		document.getElementsByTagName('input')[0].value = '';document.getElementsByTagName('input')[1].value = '';document.getElementsByTagName('input')[2].value = '';document.getElementsByTagName('input')[3].value = '';

		$btn.click(function(){
			$div.remove();
		});
	}
}