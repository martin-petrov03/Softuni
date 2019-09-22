handlers.getHome = async function (ctx) {
  ctx.isAuth = userService.isAuth();
  ctx.username = sessionStorage.getItem('username');

  if(ctx.isAuth){
    let events = await eventService.getEvents();  
    ctx.events = events;
    
    if(ctx.events.length < 1){
      ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'    
      }).then(function () {    
        this.partial('../views/notFound.hbs');
      }).catch(function () {
        notifications.showError('Cannot load NotFound template');
      });
      return;
    }
  }

  ctx.loadPartials({
    header: '../views/common/header.hbs',
    footer: '../views/common/footer.hbs',
    event: '../views/event.hbs'
  }).then(function () {    
    this.partial('../views/home.hbs');    
  }).catch(function () {
    notifications.showError('Cannot load Event template');
  });
}