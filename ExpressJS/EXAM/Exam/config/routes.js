const controllers = require('../controllers');
const restrictedPages = require('./auth');

module.exports = app => {
    app.get('/', controllers.home.index);
    app.get('/register', controllers.user.registerGet);
    app.post('/register', controllers.user.registerPost);
    app.post('/logout', controllers.user.logout);
    app.get('/login', controllers.user.loginGet);
    app.post('/login', controllers.user.loginPost);

    app.get('/team/create', restrictedPages.hasRole('Admin'), controllers.event.createTeamGet);
    app.get('/project/create', restrictedPages.hasRole('Admin'), controllers.event.createProjectGet);
    app.post('/team/create', restrictedPages.hasRole('Admin'), controllers.event.createTeam);
    app.post('/project/create', restrictedPages.hasRole('Admin'), controllers.event.createProject);
    app.get('/teams/all', controllers.event.teamPageGet);
    app.get('/projects/all', restrictedPages.isAuthed, controllers.event.projectPageGet);
    app.post('/team/distribute', controllers.event.distributeTeam);
    app.post('/project/distribute', controllers.event.distributeProject);
    app.get('/user/profile', restrictedPages.isAuthed, controllers.user.profileGet);
    app.post('/team/leave/:teamName', restrictedPages.isAuthed, controllers.event.leaveTeam);
    
    //search requests
    app.get('/project/search', controllers.event.searchProject);
    app.get('/team/search', controllers.event.searchTeam);
    
    app.all('*', (req, res) => {
        res.status(404);
        res.send('404 Not Found');
        res.end();
    });
};