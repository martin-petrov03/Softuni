const homeController = require('../controllers/home');
const userController = require('../controllers/cube');

module.exports = app => {
    //GET requests
    app.get('/', homeController.loadHomePage);
    app.get('/', userController.loadCubes);
    app.get('/about', homeController.loadAboutPage);
    app.get('/details/:id', homeController.loadDetailsPage);
    app.get('/create', homeController.loadCreatePage);
    app.get('/search', homeController.search);

    //POST requests
    app.post('/create', userController.createCube);    
};