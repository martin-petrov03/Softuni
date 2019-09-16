window.handler = window.handler || {};

handler.getHome = function (contex) {
    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');

    contex.loadPartials({
      header: '../views/common/header.hbs',
      footer: '../views/common/footer.hbs',
    }).then(function () {        
        this.partial('views/home/homePage.hbs');
    }).catch(function () {
        notifications.showError('Cannot load home templates');
    });
}