let Tag = require('./../models/TagSchema');
let Image = require('./../models/ImageSchema');
const fs = require('fs');

module.exports = (req, res) => {
  if (req.pathname === '/' && req.method === 'GET') {
    fs.readFile('./views/index.html', (err, data) => {
      if (err) {
        console.log(err)
        return
      }
      res.writeHead(200, {
        'Content-Type': 'text/html'
      });
      let dispalyTags = '';

      Tag.find({}).then(tags => {
        for (let tag of tags) {
          dispalyTags += `<div class='tag' id="${tag._id}">${tag.name}</div>`;
        }

        data = data
          .toString()
          .replace(`<div class='replaceMe'></div>`, dispalyTags);               
      });
      
      Image.find({}, function(error, images) {
        if(error){
          console.log(error);
          return;
        }

        res.write(data);

        let headline = `<h1 id="headline">Images</h1><br>`;
        res.write(headline);

        images.forEach(image => {                   
          let currentImage = `
           <div class="image">
             <img src="${image.url}" class="imageUrl" />
             <h3 class="imageDescription">${image.description}</h3>
             <p class="imageDate">${image.creationDate}</p>
           </div>`;
           res.write(currentImage);           
        });
        res.end();
      });
    });    
  } else {
    return true
  }
}