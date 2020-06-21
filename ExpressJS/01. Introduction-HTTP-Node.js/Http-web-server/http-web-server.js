const http = require('http');
const fs = require('fs');

const port = 8090;
http.createServer((req, res) => {    
    if(req.method === 'GET'){  
        if (req.url == '/') {//load Home Page
            fs.readFile('index.html',function (err, data){
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.write(data);
                res.end();
            });
        }else if(req.url == '/login'){//load Login Page
            fs.readFile('login.html',function (err, data){
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.write(data);
                res.end();
            });
        }
    }
})
.listen(port);

console.log('Web Server started at port: ' + port);