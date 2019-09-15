$(() => {
    const app = Sammy('#root', function(){
        this.use('Handlebars', 'hbs');

        this.get('/', handler.getHome);
        this.get('/index.html', handler.getHome);
        this.get('#/home', handler.getHome);
        
        this.get('#/login', handler.getLogin);
        this.get('#/register', handler.getRegister);

        this.get('#/myPets', handler.getMyPets);

        this.get('#/addPet', handler.addPet);
        this.get('#/deletePet', handler.getDeletePet);
        this.get('#/dashboard(/:category)?', handler.getAllPets);

        this.get('#/logout', handler.logoutUser);

        this.post('#/register', handler.registerUser);
        this.post('#/login', handler.loginUser);

        this.post('#/createPet', handler.createPet);
    });
    app.run('#/home');
});