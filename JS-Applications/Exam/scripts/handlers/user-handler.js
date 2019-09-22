handlers.getRegister = function (ctx) {
  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs'
  }).then(function () {
    this.partial('../views/register.hbs');
  }).catch(function (err) {
    notifications.showError('Cannot load home template');
  });
}

handlers.getLogin = function (ctx) {
  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs'
  }).then(function () {
    this.partial('../views/login.hbs');
  }).catch(function (err) {
    notifications.showError('Cannot load home template');
  });
}

handlers.registerUser = function (ctx) {
  let username = ctx.params.username;
  let password = ctx.params.password;
  let repeatPassword = ctx.params.repeatPassword;  
  
  if(username.length < 3){
    notifications.showError('The username should be at least 3 characters long');
    return;
  }else if(password.length < 6){
    notifications.showError('The password should be at least 6 characters long');
    return;
  } else if (repeatPassword !== password) {
    console.log(repeatPassword);
    console.log(password);
    notifications.showError('Passwords must match');
    return;
  } 

  userService.register(username, password).then((res) => {
    userService.saveSession(res);
    notifications.showSuccess('User registered successful.');
    ctx.redirect('#/home');
  }).catch(function (err) {
    notifications.showError(err.responseJSON.description);
  });
}

handlers.logoutUser = function (ctx) {
  userService.logout().then(() => {
    sessionStorage.clear();
    notifications.showSuccess('User logged out successfully.');
    ctx.redirect('#/home');
  })
}

handlers.loginUser = function (ctx) {
  let username = ctx.params.username;
  let password = ctx.params.password;
  userService.login(username, password).then((res) => {
    userService.saveSession(res);
    notifications.showSuccess('Login successful');
    ctx.redirect('#/home');
  }).catch(function (err) {
    notifications.showError(err.responseJSON.description);
  });
}