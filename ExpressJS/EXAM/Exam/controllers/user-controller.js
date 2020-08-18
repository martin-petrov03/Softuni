const encryption = require('../util/encryption');
const User = require('../models/User');
const Project = require('../models/Project');
const Team = require('../models/Team');

module.exports = {
    registerGet: (req, res) => {
        res.render('users/register');
    },
    registerPost: async (req, res) => {
        const reqUser = req.body;
        const salt = encryption.generateSalt();
        const hashedPass =
            encryption.generateHashedPassword(salt, reqUser.password);
        try {
            const user = await User.create({
                username: reqUser.username,
                hashedPass,
                salt,
                firstName: reqUser.firstName,
                lastName: reqUser.lastName,
                roles: []
            });
            req.logIn(user, (err, user) => {
                if (err) {
                    res.locals.globalError = err;
                    res.render('users/register', user);
                } else {
                    res.redirect('/');
                }
            });
        } catch (e) {
            console.log(e);
            res.locals.globalError = e;
            res.render('users/register');
        }
    },
    logout: (req, res) => {
        req.logout();
        res.redirect('/');
    },
    loginGet: (req, res) => {
        res.render('users/login');
    },
    loginPost: async (req, res) => {
        const reqUser = req.body;
        try {
            const user = await User.findOne({ username: reqUser.username });
            if (!user) {
                errorHandler('Invalid user data');
                return;
            }
            if (!user.authenticate(reqUser.password)) {
                errorHandler('Invalid user data');
                return;
            }
            req.logIn(user, (err, user) => {
                if (err) {
                    errorHandler(err);
                } else {
                    res.redirect('/');
                }
            });
        } catch (e) {
            errorHandler(e);
        }

        function errorHandler(e) {
            console.log(e);
            res.locals.globalError = e;
            res.render('users/login');
        }
    },
    profileGet: async (req, res) => {
        const user = req.user;
        const profilePictureUrl = req.user.profilePicture;
        let teams = 'You have no teams!';

        if(user.teams){
            if(user.teams.length > 0){            
                teams = user.teams;
                let projects = [];
                teams.forEach(async (team) => {
                    const currentTeams = await Team.find({ name: team });
                    currentTeams.forEach((currentTeam) => {                        
                        if(currentTeam.members[0].includes(req.user.username)){                            
                            projects.push(currentTeam.projects.filter((t={},a=>!(t[a]=a in t)))[0]);
                        }
                     });
                    projects = projects[0];
                    if(projects.length === 0){
                        projects = [ 'You have no projects!' ];
                    }
                
                    res.render('users/profile', { teams, projects, profilePictureUrl, areThereAnyTeams: true });
                });        
            }else{
                res.render('users/profile', { teams, projects: [ 'You have no projects!' ], profilePictureUrl, areThereAnyTeams: false });
            }
        }else{            
            res.render('users/profile', { teams, projects: [ 'You have no projects!' ], profilePictureUrl,areThereAnyTeams: false });
        }
    }
};