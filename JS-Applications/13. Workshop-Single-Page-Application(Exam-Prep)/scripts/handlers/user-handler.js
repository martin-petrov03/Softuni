window.handler = window.handler || {};

handler.getLogin = function (contex) {
    contex.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
    }).then(function () {        
        this.partial('views/user/loginPage.hbs');
    }).catch(function () {
        notifications.showError('Cannot load login templates');
    });
}

handler.getRegister = function (contex) {
    contex.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
    }).then(function () {        
        this.partial('views/user/registerPage.hbs');
    }).catch(function () {
        notifications.showError('Cannot load register templates');
    });
}

handler.loginUser = function (ctx) {
    let username = ctx.params.username;
    let password = ctx.params.password;
    userService.login(username, password).then((res) => {
        userService.saveSession(res);
        notifications.showSuccess('User logged in successfully');
        ctx.redirect('#/home');
    }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
    });
}

handler.registerUser = function (ctx) {
    let username = ctx.params.username;
    let password = ctx.params.password;
    
    userService.register(username, password).then((res) => {
        userService.saveSession(res);
        notifications.showSuccess('User registered successfully');
        ctx.redirect('#/home');
    }).catch(function (err) {
        notifications.showError('Cannot register');
    });
}

handler.logoutUser = function (ctx) {
    userService.logout().then(() => {
        sessionStorage.clear();
        notifications.showSuccess('User logged out successfully');
        ctx.redirect('#/home');
    });
}