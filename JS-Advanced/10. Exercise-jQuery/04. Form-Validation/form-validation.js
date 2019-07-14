function validate() {
	const usernameRegex = /^[a-zA-Z0-9]{3,20}$/gm;
	const passwordRegex = /^\w{5,15}$/g;
	const emailRegex = /(.+)?@(.+)?\.(.+)?/g;	
	
	$('#submit').click(checkData);
	$('#company').click(showHideCompanyInfo);	
	function checkData(ev){
		//don't refresh the page 	
		ev.preventDefault();

		let isAllRight = true;
		
		//username validation
		let usernameInputValue = $('#username').val();
		if(!usernameRegex.test(usernameInputValue)){
			$('#username').css('border-color', 'red');
			isAllRight = false;
		}

		//email validation
		let emailInputValue = $('#email').val();
		if(!emailRegex.test(emailInputValue)){
			$('#email').css('border-color', 'red');
			isAllRight = false;
		}

		//password and confirm password validation
		let password = $('#password');
		let confirmPassword = $('#confirm-password');		
		if(!passwordRegex.test(password.val())){
			password.css('border-color', 'red');
			isAllRight = false;
		}

		if(password.val() !== confirmPassword.val() || password.css('border-color') === 'rgb(255, 0, 0)'){
			confirmPassword.css('border-color', 'red');	
			password.css('border-color', 'red');
			isAllRight = false;
		}		
		//validate company name
		if($('#companyInfo').css('display') === 'block' && ($('#companyNumber').val() < 1000 || $('#companyNumber').val() > 9999)){
			$('#companyNumber').css('border-color', 'red');
			isAllRight = false;
		}		
		if(isAllRight){
			$('#valid').css('display', 'block');
		}
	}
	function showHideCompanyInfo(){		
		if($('#companyInfo').css('display') == 'none'){
			$('#companyInfo').css('display', 'block');
		}else{
			$('#companyInfo').css('display', 'none');
		}
	}
}
