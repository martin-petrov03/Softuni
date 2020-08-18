const Team = require('../models/Team');
const Project = require('../models/Project');
const User = require('../models/User');

module.exports = {
    createTeamGet: (req, res) => {
        res.render('events/createTeam');
    },
    createProjectGet: (req, res) => {
        res.render('events/createProject');
    },
    createTeam: (req, res) => {
        const teamName = req.body.teamName;

        Team.create({ name: teamName }).then(() => {
            res.redirect('/');
        })
        .catch((err) => {
            console.log(err);
        });
    },
    createProject: (req, res) => {
        const projectName = req.body.projectName;
        const description = req.body.description;

        Project.create({ name: projectName, description }).then(() => {
            res.redirect('/');
        })
        .catch((err) => {            
            res.locals.globalError = err;
            res.render('events/createProject');
        });
    },
    teamPageGet: async (req, res) => {
        try{            
            if(req.user.roles.length !== 0){
                const users = await User.find({}).select('_id username');
                const teams = await Team.find({}).select('_id name');
                res.render('events/teams', { users, teams });
                return;
            }                
            let teams = await Team.find({});
            let counter = 0;
            teams.forEach((team) => {
                if(team.members.length > 0){
                    let membersArr = teams[0].members[0];
                                
                    membersArr = membersArr.filter(function(elem, pos) {
                        return membersArr.indexOf(elem) == pos;
                    });                
                    teams[counter].members = membersArr[0];                
                    teams[counter].projects.filter(function(elem, pos) {
                        return teams[counter].projects.indexOf(elem) == pos;
                    });
                    if(tema.projects.length === 0){
                        teams[counter].projects = 'Team has no projects';
                    }else{                        
                        teams[counter].projects = teams[counter].projects.filter((t={},a=>!(t[a]=a in t)));
                    }
                }else{
                    teams[counter].members = 'Team has no members';
                }
                if(team.projects.length === 0){
                    teams[counter].projects = 'Team has no projects';
                }
                counter++;
            });
console.log(teams);
            res.render('events/teams', { teams });
        }
        catch(err){
            res.locals.globalError = err;
            res.render('events/teams');
        }
    },
    projectPageGet: async (req, res) => {
        try{            
            if(req.user.roles.length !== 0){
                const projects = await Project.find({}).select('_id name');
                const teams = await Team.find({}).select('_id name');                
                res.render('events/project', { projects, teams });
                return;
            }            
            const projects = await Project.find({});
            
            let counter = 0;
            projects.forEach((project) => {
                project.team = project.team.filter(function(elem, pos) {
                    return project.team.indexOf(elem) == pos;
                });
                if(project.team.length === 0){
                    projects[counter].team = 'No Team assigned';
                }
                counter++;
            });            
            res.render('events/project', { projects });
        }
        catch(err){
            res.locals.globalError = err;
            res.render('events/project');
        }
    },
    distributeTeam: async (req, res) => {
        const { user, team } = req.body;

        const currentTeam = await Team.findById(team);
        const currentUser = await User.findById(user);

        currentUser.teams.push(currentTeam.name);
        currentTeam.members.push(currentUser.username);

        await currentUser.save();
        await currentTeam.save();
        res.redirect('/');
    },
    distributeProject: async (req, res) => {
        const { team, project } = req.body;

        const currentProject = await Project.findById(project);
        const currentTeam = await Team.findById(team);

        currentProject.team.push(currentTeam.name);
        currentTeam.projects.push(currentProject.name);
        
        await currentTeam.save();
        await currentProject.save();
        res.redirect('/');
    },
    leaveTeam: async (req, res) => {        
        const teamName = req.params.teamName;
        const user = await User.findById(req.user._id);
        user.teams = user.teams.filter((t={},a=>!(t[a]=a in t)));
        user.teams.forEach((team) => {
            if(team == teamName){
                const index = user.teams.indexOf(team);
                if (index !== -1) user.teams.splice(index, 1);
            }
        });
        
        let team = await Team.find({ name: teamName });
        team = team[0];        
        team.members[0].forEach((member) => {
            if(member === req.user.username){
                const index = team.members[0].indexOf(member);
                if (index !== -1) team.members[0].splice(index, 1);
                if(team.members[0].length == 0){
                    team.members = [];
                }
            }
        });
        
        await user.save();
        await team.save();
        res.redirect('/')
    },
    searchProject: (req, res) => {        
        const searchedProjectName = req.query.searchedProject.toLowerCase();
        console.log(searchedProjectName);
        Project.find({})
            .then((projects) => {
                const filteredProjects = projects.filter(project => project.name.toLowerCase().includes(searchedProjectName));
                res.render('events/project', { projects: filteredProjects });
            })
            .catch((error) => {
                console.log(error);
            });
    },
    searchTeam: (req, res) => {        
        const searchedTeamName = req.query.searchedTeam.toLowerCase();        
        Team.find({})
            .then((teams) => {
                const filteredTeams = teams.filter(team => team.name.toLowerCase().includes(searchedTeamName));
                res.render('events/teams', { teams: filteredTeams });
            })
            .catch((error) => {
                console.log(error);
            });
    }
};