const mongoose = require('mongoose');
const { cubeModel, accessoriesModel } = require('../models');

function create(req, res, next) {
    const {name = null, description = null, imageUrl = null, } = accessoriesModel.create({name, description, imageUrl})
    .then(created => {
        res.redirect('/');
    })
    .catch(next);
}

function attach(req, res, next) {
    const { id: cubeId } = req.params;
    cubeModel.findById(cubeModel).then(cube => {
        res.render('/')
    }
}

module.exports = {
    create,
    attach
};