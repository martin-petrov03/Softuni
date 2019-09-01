handlers.getLogin = function(contex){
    contex.loadPartials(
        {
            header: '../templates/common/header.hbs',
            footer: '../templates/common/footer.hbs'
        }
    ).then(function() {
        this.partial('../templates/login.hbs');
    }).catch((err) => notifications.showError(err.responseJSON.description));
}