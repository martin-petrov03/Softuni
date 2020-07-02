const User = require('../models/User');
const Car = require('../models/Car');
const Rent = require('../models/Rent');
const encryption = require('../util/encryption');

module.exports = {
    registerGet: (req, res) => {
        res.render('user/register');
    },
    registerPost: async (req, res) => {
        const userBody = req.body;
        const username = userBody.username;
        const password = userBody.password;
        const repeatPassword = userBody.repeatPassword;
        const firstName = userBody.firstName;
        const lastName = userBody.lastName;
        
        if(password === '' || repeatPassword === ''){
            userBody.error = 'Fields should be filled!';
            res.render('user/register', userBody);
            return;
        }

        if(password !== repeatPassword){
            userBody.error = 'Passwords should match!';
            res.render('user/register', userBody);            
            return;
        }

        const salt = encryption.generateSalt();
        const hashedPass = encryption.generateHashedPassword(salt, password);

        const userData = {
            username,
            hashedPass,
            salt,
            firstName,
            lastName,
            roles: ['User']
        };

        try{
            const user = await User.create(userData);
            
            req.logIn(user, (err) => {
                if(err){
                    userBody.error = err;
                    res.render('user/register', userBody);
                    return;
                }else{
                    res.redirect('/');
                }
            });
        }
        catch(err){
            userBody.error = err;
            res.render('user/register', userBody);
        }
    },
    logout: (req, res) => {
        req.logout();
        res.redirect('/');
    },
    loginGet: (req, res) => {
        res.render('user/login');
    },
    loginPost: async (req, res) => {
        const userBody = req.body;

        try{
            const user = await User.findOne({ username: userBody.username});

            if(!user){
                userBody.error = 'Invalid username!';
                res.render('user/login', userBody);
                return;
            }

            if(!user.authenticate(userBody.password)){
                userBody.error = 'Invalid password!';
                res.render('user/login', userBody);
                return;
            }

            req.logIn(user, (err) => {
                if(err){
                    userBody.error = err;
                    res.render('user/login', userBody);
                    return;
                }
                res.redirect('/');
            });
        }
        catch(err){
            userBody.error = err;
            res.render('user/login', userBody);
        }
    },
    rents: async (req, res) => {        
        await Rent.find({owner: req.user._id})
        .populate('car')
        .select('model pricePerDay, days')
        .then((rents) => {
            let cars = [];
            rents.forEach((rent) => {
                rent.car.days = rent.days; 
                cars.push(rent.car);
            });
            console.log(cars);
            res.render('user/rented', {cars});
        })
        .catch(err => {
            res.render('car/all', {error: err});
        });
    }
};