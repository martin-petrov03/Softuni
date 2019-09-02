handlers.getRegister = function(contex){
    contex.loadPartials(
        {
            header: '../templates/common/header.hbs',
            footer: '../templates/common/footer.hbs'
        }
    ).then(function() {
        this.partial('../templates/register.hbs');
    }).catch((err) => notifications.showError(err.responseJSON.description))
}