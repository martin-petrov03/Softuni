const homeHandler= require('./homeHandler')
const addImageHandler = require('./addImageHandler')
const addTagHandler = require('./tagHandler')
const staticFileHandler = require('./staticHandler')

module.exports = [homeHandler,addTagHandler,addImageHandler,staticFileHandler]