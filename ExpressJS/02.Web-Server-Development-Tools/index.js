const http = require('http');
const fs = require('fs');
const handlers = require('./handlers/index');

const port = 8092;
http.createServer((req, res) => {    
    for(let handler of handlers){
        if(handler(req, res) == false){
            break;
        }       
    }
    /* if(req.method === 'GET'){
            if (req.url === '/') {//load Home Page
                fs.readFile('views/home.html',function (err, data){
                    res.writeHead(200, { 'Content-Type': 'text/html' });
                    res.write(data);
                    res.end();
                });
            }else if(req.url === 'viewAllMovies'){//load Login Page
                fs.readFile('./views/viewAll.html',function (err, data){
                    res.writeHead(200, { 'Content-Type': 'text/html' });
                    res.write(data);
                    res.end();
                });
            }
        } */
})
.listen(port);

console.log('Web Server started at port: ' + port);