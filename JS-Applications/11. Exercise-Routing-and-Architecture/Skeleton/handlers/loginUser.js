handlers.loginUser = function(contex) {
    let username = contex.params.username;
    let password = contex.params.password;
    userService.login(username, password).then((response) => {
        userService.saveSession(response);
        notifications.showSuccess('User logged in successfully');
        contex.redirect('#/home');
    }).catch((err) => notifications.showError(err.responseJSON.description))
}