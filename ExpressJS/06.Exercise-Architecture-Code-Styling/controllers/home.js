const Article = require('../models/Article');

module.exports = {
  index: async(req, res) => {
    const articles = await Article.find({}).select('title content author').populate('author').select('fullName');    
    res.render('home/index', {article: articles});
  }
}
