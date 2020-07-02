const restrictedPages = require('./auth');
const homeController = require('../controllers/home');
const userController = require('../controllers/user');
const carController = require('../controllers/car');

module.exports = app => {
    //users get requests
    app.get('/', homeController.index);
    app.get('/user/register', restrictedPages.isAnonymous, userController.registerGet);
    app.get('/user/login', restrictedPages.isAnonymous, userController.loginGet);
    app.get('/user/rents', restrictedPages.isAuthed, userController.rents);    

    //users post requests
    app.post('/user/register', restrictedPages.isAnonymous, userController.registerPost);
    app.post('/user/login', restrictedPages.isAnonymous, userController.loginPost);
    app.post('/user/logout', userController.logout);
    
    //cars get requests    
    app.get('/car/add', restrictedPages.hasRole('Admin'), carController.addGet);
    app.get('/car/all', carController.allCars);
    app.get('/car/rent/:id', restrictedPages.isAuthed, carController.getRent);
    app.get('/car/edit/:id', restrictedPages.hasRole('Admin'), carController.editGet);
    app.get('/search', carController.search);
    
    //cars post requests
    app.post('/car/add', restrictedPages.hasRole('Admin'), carController.addPost);
    app.post('/car/rent/:id', restrictedPages.isAuthed, carController.rent);
    app.post('/car/edit/:id', restrictedPages.hasRole('Admin'), carController.editPost);

    app.all('*', (req, res) => {
        res.status(404);
        res.send('404 Not Found');
        res.end();
    });
};