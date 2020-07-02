const Car = require('../models/Car');
const Rent = require('../models/Rent');

module.exports = {
    addGet: (req, res) => {
        res.render('car/add');
    },
    addPost: (req, res) => {
        const userData = req.body;
        userData.pricePerDay = Number(userData.pricePerDay);

        if(userData.model === '' || userData.image === '' || !userData.image.startsWith('https://') || userData.pricePerDay < 1){
            userData.error = 'The input is invalid!';
            res.render('car/add', userData);
            return;
        }        
        
        Car.create(userData).then(() => {
            res.redirect('/');
        })
        ;
    },
    allCars: (req, res) => {
        try{
            Car.find({isRented: false}).then((cars) => {                
                res.render('car/all', { cars });
            });            
        }
        catch(err){            
            res.render('home/index', {error: err});
        }
    },
    getRent: (req, res) => {
        const cardId = req.params.id;
        Car.findById(cardId).then((car) => {            
            res.render('car/rent', car);
        })
        .catch(err => {
            res.render('car/all', {error: err});
        });
    },
    rent: (req, res) => {
        const userData = req.body;
        
        const cardId = req.params.id;
        Car.findById(cardId).then((car) => {   
            const rent = Rent.create({
                days: Number(userData.days),
                car: car._id,
                owner: req.user._id
            }).then(() => {               
                car.isRented = true;
                car.save();
                res.render('car/all');
            });
        })
        .catch(err => {
            res.render('car/all', {error: err});
        });
    },
    editGet: (req, res) => {
        Car.find({_id: req.params.id}).then((cars) => {            
            res.render('car/edit', cars[0]);
        })        
    },
    editPost: (req, res) => {        
        Car.findById(req.params.id).then((car) => {            
            car.model = req.body.model;
            car.image = req.body.image;
            car.pricePerDay = req.body.pricePerDay;

            car.save().then(() => {
                res.redirect('/car/all');
            });
        }).catch(err => {
            res.render('car/all', {error: err});
        });
        
    },
    search: (req, res) => {
        const searchedModel = req.query.model;

        const suitableCars = [];
        Car.find({}).then((cars) => {
            cars.forEach(car => {
                if(!car.isRented){                
                    if(car.model.toLowerCase().includes(searchedModel.toLowerCase())){
                        suitableCars.push(car);
                    }
                }
            });
            res.render('car/all', { cars: suitableCars });           
        });                
    }
}