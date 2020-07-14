const Article = require('../models/Article');

module.exports = {
    index: async (req, res) => {     
        try{            
            const articles = await Article.find({})
            .sort({ creationDate: 'descending'})
            .limit(3);            
            
            let latestArticle = articles[0];
            if(!latestArticle){
               latestArticle = {
                    title: 'Article Not Found',
                    content: 'Empty'
                };
            }

            latestArticle.content = latestArticle.content
                .split(' ')
                .slice(0, 50)
                .join(' ');
            console.log(req.user);
            res.render('home/index', { latestArticle, articles});
        }
        catch(error){
            console.log(error);
        }        
    },
    serachArticle: (req, res) => {
        const searchedTitle = req.query.title.toLowerCase();
        Article.find({})
            .then((articles) => {
                const filteredArticles = articles.filter(article => article.title.toLowerCase().includes(searchedTitle));
                res.render('home/search-results', { result: searchedTitle, articles: filteredArticles });
            })
            .catch((error) => {
                console.log(error);
            });
    }
};