const userController = require('../controllers/cube');
const cubeModel = require('../models/Cube');

function loadHomePage (req, res) {
    userController.loadCubes(req, res);
}

function loadAboutPage (req, res) {
    res.render('about');
}

function loadDetailsPage (req, res) {
    const cudeId = req.params.id;
    cubeModel.findById(cudeId)
    .select('_id name description imageUrl difficulty')
    .then((cube) => {              
        res.render('details', cube);
    });
}

function loadCreatePage (req, res) {
    res.render('create');
}

function search (req, res, next) {
    let {name, from, to} = req.query;
    from = Number(from);
    to = Number(to);   

    if(name === '' && from === '' || to === ''){
        cubeModel.find({})
        .then((cubes) => {               
            filtered = cubes;                
            res.render('index', { cubes: filtered });
        })
        .catch(next);
    }else{        
        if(from === 0){
            from = 1;
        }
        if(to === 0){
            to = 10;
        }

        cubeModel.find({})
        .where('difficulty')        
        .gte(from)
        .lte(to)
        .then((cubes) => {
            let filtered = cubes;
            if(name !== ''){                
                filtered = cubes.filter(cube => cube.name.toLowerCase().includes(name.toLowerCase()));
            }
            
            res.render('index', { cubes: filtered, name, from, to });
        })
        .catch(next);
    }    
}


module.exports = {
    loadHomePage,
    loadAboutPage,
    loadDetailsPage,
    loadCreatePage,
    search
}