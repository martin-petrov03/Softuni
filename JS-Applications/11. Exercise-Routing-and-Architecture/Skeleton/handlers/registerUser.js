handlers.registerUser = function (contex){
    let username = contex.params.username;
    let password = contex.params.password;
    let repeatPassword = contex.params.repeatPassword;
    
    if(password !== repeatPassword){
      notifications.showError('Passwords must match');
      return;
    }
    userService.register(username, password).then((response) => {
        userService.saveSession(response);
        notifications.showSuccess('User logged in successfully');
        contex.redirect('#/home');
      }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
      });
}