const restrictedPages = require('../config/auth');
const controller = require('../controllers/index');

module.exports = (app) => {
    app.get('/', controller.homeController.index);

    //users requests
    app.get('/user/register', restrictedPages.isAnonymous, controller.userController.registerGet);
    app.post('/user/register', restrictedPages.isAnonymous, controller.userController.registerPost);
    app.get('/user/login', restrictedPages.isAnonymous, controller.userController.loginGet);
    app.post('/user/login', restrictedPages.isAnonymous, controller.userController.loginPost);
    app.get('/user/logout', restrictedPages.isAuthed, controller.userController.logout);
    
    //articles requests
    app.get('/article/create', restrictedPages.isAuthed, controller.articleController.getCreateArticle);
    app.post('/article/create', restrictedPages.isAuthed, controller.articleController.createArticle);
    app.get('/article/details/:id', controller.articleController.getDetailsPage);
    app.get('/article/edit/:id', controller.articleController.getEditArticlePage);
    app.post('/article/edit/:id', controller.articleController.editArticle);
    app.get('/article/delete/:id', controller.articleController.getDeleteArticlePage);   
    app.post('/article/delete/:id', controller.articleController.deleteArticle); 
};