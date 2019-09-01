handlers.getHome = function (contex){
    contex.isAuth = sessionStorage.getItem('authtoken') !== null;
    if(sessionStorage.getItem('authtoken') !== null){
        contex.username = sessionStorage.getItem('username');
    }
    contex.loadPartials(
        {
            header: '../templates/common/header.hbs',
            footer: '../templates/common/footer.hbs'
        }
    ).then(function() {
        this.partial('templates/home.hbs');
    }).catch((err) => notifications.showError(err.responseJSON.description));
}