const handlers = {}

$(() => {
  const app = Sammy('#root', function () {
    this.use('Handlebars', 'hbs');
    // home page routes
    this.get('/index.html', handlers.getHome);
    this.get('/', handlers.getHome);
    this.get('#/home', handlers.getHome);

    // user routes
    this.get('#/register', handlers.getRegister);
    this.get('#/login', handlers.getLogin);

    this.post('#/register', handlers.registerUser);
    this.post('#/login', handlers.loginUser);
    this.get('#/logout', handlers.logoutUser);
    
    // ADD YOUR ROUTES HERE
    this.get('#/organizeEvent', handlers.getOrganizeEvent);
    this.post('#/organizeEvent', handlers.organizeEvent);
    this.get(`#/moreInfo/:id`, handlers.getMoreInfo);
    this.get(`#/editEvent/:id`, handlers.getEditView);
    this.post('#/editEvent/:id', handlers.editEvent);
    this.get('#/joinTheEvent/:id', handlers.joinInTheEvent); 
    this.get('#/deleteEvent/:id', handlers.removeEvent);
    this.get('#/profile', handlers.getProfile);
    this.get('#/getCreateEvent', handlers.getCreateEvent);
  });
  app.run();
});
