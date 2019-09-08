handlers.getAllSongs = async function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    let songs = await songService.getAllSongs();
    let userId = sessionStorage.getItem('id');
    
    songs.forEach((song) => song.isCreator = song._acl.creator === userId);
    ctx.songs = songs;    

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
        song: '../views/song/song.hbs'
      }).then(function () {
        this.partial('../views/song/allSongsPage.hbs');
      }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
      });
}

handlers.getCreateSong = function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
      }).then(function () {
        this.partial('../views/song/createSongPage.hbs');
      }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
      });
}

handlers.getMySongs = function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');
    

    songService.getMySongs().then(async function (response){            
      let songs = await songService.getAllSongs();
      let userId = sessionStorage.getItem('id');
      
      songs.forEach((song) => song.isCreator == song._acl.creator === userId);
      ctx.songs = songs;    
      
      ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs',
        song: '../views/song/song.hbs'
      }).then(function () {
        this.partial('../views/song/mySongsPage.hbs');
      }).catch(function (err) {
        notifications.showError(err.responseJSON.description);
      });
    });
}

handlers.createSong = function (ctx){
    let data = {...ctx.params, likeCounter: 0, listenCounter: 0};

    //validate
    try{
      validate();
      ctx.redirect('#/mySongs');
    }
    catch{
        songService.createSong(data).then(function(){
          notifications.showSuccess('The song is created successfully');
          ctx.redirect('#/allSongs')
        }).catch(function(err){
            notifications.showError(err.responseJSON.description);
        });
    }

    function validate(){
        if(data.title.length < 6){
          notifications.showError('The title should be at least 6 characters long');
          return false;
        } else if(data.artist.length < 3){
          notifications.showError('The artist should be at least 3 characters long');
          return false;
        } else if(!(data.imageURL.startsWith('http://') || data.imageURL.startsWith('data'))){
          notifications.showError('The url is invalid');
          return false;
        }
    }   
}

handlers.removeSong = function (ctx){
    songService.removeSong(ctx.params.id).then(function(){
        notifications.showSuccess('The song is removed successfully');
        ctx.redirect('#/allSongs')
    }).catch(function(err){
        notifications.showError(err.responseJSON.description);
    });
}

handlers.likeSong = async function (ctx){
  let id = ctx.params.id;
  let song = await songService.getASong(id);

  let newLikes = Number(song.likeCounter) + 1;
  song.likeCounter = newLikes;

  songService.likeSong(id, song).then(function(id, song){
      notifications.showSuccess('Song was liked successfully');
      ctx.redirect('#/allSongs')
  }).catch(function(err){
      notifications.showError(err.responseJSON.description);
  });
}

handlers.listenSong = async function (ctx){
  let id = ctx.params.id;
  let song = await songService.getASong(id);

  let newListens = Number(song.listenCounter) + 1;
  song.listenCounter = newListens;

  songService.listenSong(id, song).then(function(id, song){
      notifications.showSuccess('Song was listened successfully');
      ctx.redirect('#/allSongs')
  }).catch(function(err){
      notifications.showError(err.responseJSON.description);
  });
}