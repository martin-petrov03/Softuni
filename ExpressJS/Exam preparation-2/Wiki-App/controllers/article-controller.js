const Article = require('../models/Article');
const Edit = require('../models/Edit');
const User = require('../models/Article');

module.exports = {
    getCreateArticlePage: (req, res) => {
        res.render('articles/create');
    },
    createArticle: async (req, res) => {
        const { title, content } = req.body;
        try{
            const article = new Article({
                title,
                content
            });
            const edit = new Edit({ 
                title,
                content,
                author: req.user._id
            });
            await article.save();
            await edit.save();

            article.edits.push(edit._id);
            edit.article = article._id;
            req.user.edits.push(edit._id);
            
            await Promise.all([article.save(), edit.save()]);
            res.redirect('/');
        }
        catch (error){
            console.log(error);
        }
    },
    listAll: async (req, res) => {
        try{
            const articles = await Article
                .find({})
                .sort({ 'title': 'ascending' })
                .select('_id title');
            res.render('articles/all-articles', { articles });
        }
        catch(error){
            console.log(error);
        }
    },
    displayArticle: (req, res) => {
        const articleId = req.params.id;

        Article.findById(articleId)           
            .then((article) => {                        
                let splitedContent = article.content
                .split('\r\n\r\n');
                article.splitedContent = splitedContent;

                res.render('articles/article', article);
            })
            .catch((error) => {
                console.log(error);
            });
    },
    getEditPage: (req, res) => {
        Article.findById(req.params.id)
            .then((article) => {
                if(article.isLocked && req.user.roles.indexOf('Admin') === -1){
                    res.locals.globalError = 'Article is locked!';
                    res.redirect('/');
                    return;
                }

                article.content = article.edits[article.edits.length - 1].content;          
                res.render('articles/edit', article);
            })
            .catch((error) => {
                console.log(error)
            })
    },
    getEditPage: (req, res) => {
        Article.findById(req.params.id)
          .then((article) => {
            if (article.isLocked && req.user.roles.indexOf('Admin') === -1) {
              res.locals.globalError = 'Article is locked!';
              res.redirect('/');
              return;
            }
                
            res.render('articles/edit', article);
          })
          .catch(console.error);
      },
    editArticle: (req, res) => {
        const articleId = req.params.id;
        const editedArticle = new Edit({
            author: req.user.id,
            content: req.body.content,
            article: articleId
        });
        Promise.all([Article.findById(articleId), Edit.create(editedArticle)])
            .then(([a, e]) => {
                req.user.edits.push(e._id);
                a.edits.push(e._id);

                return Promise.all([
                User.findOneAndUpdate(req.user._id, req.user),
                Article.findOneAndUpdate(a._id, a)
                ])
            })
            .then(() => {
                res.redirect(`/article/history/${articleId}`, editedArticle);
            })
            .catch(console.error);
    },
    getHistory: (req, res) => {
        const articleId = req.params.id;

    Article.findById(articleId)
      .populate({ 
        path: 'edits', 
        options: { 
          populate: { path: 'author' }, 
          sort: { 'creationDate': -1 } 
        } 
      })
      .then((article) => {
        res.render('article/history', article);
      })
      .catch(console.error);
    },
    lock: (req, res) => {
        Article.findById(req.params.id)
          .then((a) => {
            a.isLocked = true;
            a.save().then(() => {
              res.redirect(`/article/details/${a._id}`);
            });
          })
          .catch(console.error);
      },
      unlock: (req, res) => {
        Article.findById(req.params.id)
          .then((a) => {
            a.isLocked = false;
            a.save().then(() => {
              res.redirect(`/article/details/${a._id}`);
            })
          })
          .catch(console.error);
      },
};