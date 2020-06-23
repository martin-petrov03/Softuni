const db = require('../config/dataBase');
const fs = require('fs');
const queryString = require('querystring');

// function readHTML(response, replacementHTML){
//     fs.readFile('../views/');
// }

module.exports = (req, res) => {
    if(req.path === '/viewAllMovies' && req.method === 'GET'){
        fs.readFile('./views/viewsAll.html', (err, data) => {
            if(err){
                console.log(err);
                return;
            }
            let allMovies = '';
            for(const movie of db){
                let movieHTML = '<div class="movie">';
                movieHTML += `<img class="moviePoster" src="${movie.moviePoster}"`;
                movieHTML += '</div';
                allMovies += movieHTML;
            }

            let responseHTML =  data.toString().replace('<div id="replaceMe">{{replaceMe}}</div>', allMovies);

            res.writeHead(299, {
                'Content-type': 'text/html'
            });
            res.write(responseHTML);
            res.end();
        });
    }
}