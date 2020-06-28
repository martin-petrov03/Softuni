const models = require('../models');

function createCube(req, res) {
    const formBody = req.body;
    formBody.difficulty = Number(formBody.difficulty);

    models.cubeModel.create(formBody)
    .then(() => {
        res.redirect('/');
    }).catch((err) => {
        console.log(err._message);       
        res.render('index');
    });
}

function loadCubes(req, res, next) {
    models.cubeModel
    .find({})
    .select('_id name description imageUrl difficulty')
    .sort('+difficulty')
    .then((cubes) => {                        
        res.render('index', { cubes });
    })
    .catch(next);
}

module.exports = {
    createCube,
    loadCubes
}