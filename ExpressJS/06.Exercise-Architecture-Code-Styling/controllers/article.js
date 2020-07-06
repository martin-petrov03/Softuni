const Article = require('../models/Article');

module.exports = {
    getCreateArticle: (req, res) => {
        res.render('article/create');
    },
    createArticle: (req, res) => {
        const { title, content } = req.body;
        const article = { title, content, author: req.user._id };
        Article.create(article).then(() => {
            res.redirect('/');
        });
    },
    getDetailsPage: async(req, res) => {
        await Article.findById(req.params.id)
        .populate('author')
        .then((article) => {
            const isAuthor = req.user.isAuthor(article);
            res.render('article/details', article);
        });
    },
    getEditArticlePage: async(req, res) => {
        const articleId = req.params.id;
        const article = await Article.findById(articleId);
        res.render('article/edit', article);
    },
    editArticle: (req, res) => {
        const articleId = req.params.id;
        const { title, content } = req.body;

        Article.findById(articleId).then((article) => {
            article.title = title;
            article.content = content;
            article.author = req.user;

            article.save().then(() => {
                res.redirect('/');
            });
        });
    },
    getDeleteArticlePage: async (req, res) => {
        const articleId = req.params.id;
        Article.findById(articleId).then((article) => {
            res.render('article/delete', article);
        }).catch((err) => {
            console.log(err);
        })
    },
    deleteArticle: (req, res) => {
        const articleId = req.params.id;        
        Article.remove({ _id: articleId })
        .then(() => {
            res.redirect('/');
        });
    }
};