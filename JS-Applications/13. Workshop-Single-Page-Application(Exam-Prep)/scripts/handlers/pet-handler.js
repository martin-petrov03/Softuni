window.handler = window.handler || {};

handler.getMyPets = function (contex) {  
    
    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');
    let userId = sessionStorage.getItem('id');

    petService.getMyPets(userId).then((res) => {
        contex.myPet = res;        

        contex.loadPartials({
            header: '../views/common/header.hbs',
            footer: '../views/common/footer.hbs',
            myPet: '../views/pet/myPet.hbs'
        }).then(function () {        
            this.partial('views/pet/myPets.hbs');
        }).catch(function () {
            notifications.showError('Cannot load allPets templates');
        });
    });
}

handler.addPet = function (contex) {
    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');

    contex.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'        
    }).then(function () {
        this.partial('views/pet/addPet.hbs');
    }).catch(function () {
        notifications.showError('Cannot load createPet templates');
    });
}

handler.createPet = function (contex) {
    let data = {...contex.params, likeCounter: 0};

    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');
        
    petService.createPet(data).then(() => {
        notifications.showSuccess('The pet was added successfully');
        contex.redirect('#/dashboard/All');
    }).catch(function () {
        notifications.showError('Cannot add pet');
    });
}

handler.getAllPets = function (contex) {    
    if(contex.username === sessionStorage.getItem('username')){
        return;
    }

    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');
    
    let filter = contex.params.category.slice(1);
    petService.getAll(filter).then((res) => {
        contex.pet = res;       
        contex.loadPartials({
            header: '../views/common/header.hbs',
            footer: '../views/common/footer.hbs',
            pet: '../views/pet/pet.hbs'
        }).then(function () {        
            this.partial('views/pet/allPets.hbs');
        }).catch(function () {
            notifications.showError('Cannot load allPets templates');
        });
    })
}

handler.getDeletePet = function (contex){    
    contex.isAuth = userService.isAuth();
    contex.username = sessionStorage.getItem('username');    
    
    petService.getDelete(userId).then((res) => {
        contex.loadPartials({
            header: '../views/common/header.hbs',
            footer: '../views/common/footer.hbs'        
        }).then(function () { 
            this.partial('views/pet/deletePet.hbs');
        }).catch(function () {
            notifications.showError('Cannot delete this pet');
        });
    });
}