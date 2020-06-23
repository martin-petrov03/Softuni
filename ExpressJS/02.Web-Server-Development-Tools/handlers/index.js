const staticHandler = require('./static-handler');
const movieHandler = require('./movie-handler');
const homeHandler = require('./home-handler');

module.exports = [staticHandler, movieHandler, homeHandler];