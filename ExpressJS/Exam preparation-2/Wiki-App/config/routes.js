const controllers = require('../controllers');
const restrictedPages = require('./auth');

module.exports = app => {
    //base route
    app.get('/', controllers.home.index);

    //user routes
    app.get('/register', restrictedPages.isAnonymous, controllers.user.registerGet);
    app.post('/register', restrictedPages.isAnonymous, controllers.user.registerPost);
    app.get('/logout', restrictedPages.isAuthed, controllers.user.logout);
    app.get('/login', restrictedPages.isAnonymous, controllers.user.loginGet);
    app.post('/login', restrictedPages.isAnonymous, controllers.user.loginPost);

    //article routes
    app.get('/article/create', restrictedPages.isAuthed, controllers.article.getCreateArticlePage);
    app.post('/article/create', controllers.article.createArticle);
    app.get('/article/all', controllers.article.listAll);
    app.get('/article/display/:id', controllers.article.displayArticle);
    app.get('/article/edit/:id', restrictedPages.isAuthed, controllers.article.getEditPage);
    app.post('/article/edit/:id', restrictedPages.isAuthed, controllers.article.editArticle);
    app.get('/article/search', controllers.home.serachArticle);
    app.get('/article/history/:articleId', restrictedPages.isAuthed, controllers.article.getHistory);

    // Admin routes
    app.get('/article/lock/:id', restrictedPages.hasRole('Admin'), controllers.article.lock);
    app.get('/article/unlock/:id', restrictedPages.hasRole('Admin'), controllers.article.unlock);

    //other routes
    app.all('*', (req, res) => {
        res.status(404);
        res.send('404 Not Found');
        res.end();
    });
};