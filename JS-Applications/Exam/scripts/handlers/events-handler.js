handlers.getOrganizeEvent = function (ctx) {
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
      }).then(function () {
        this.partial('../views/organizeEvent.hbs');
      }).catch(function (err) {
        notifications.showError('Cannot load Organize Event template');
      });
}

handlers.organizeEvent = function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');    

    let data = {...ctx.params, interestedPeople: 0, organizer: sessionStorage.getItem('username')};

    if(isValid(data)){
        eventService.createEvent(data).then(() => {
            notifications.showSuccess('Event created successfully.');
            ctx.redirect('#/home');
        }).catch(() => {
            notifications.showError('Cannot organize Event');
        });
    }else{
        notifications.showError('Cannot organize Event');
    }

    function isValid(data){
        const headline = data.headline;
        const dateTime = data.dateTime;
        const description = data.description;
        const imageUrl = data.imageURL;

        if(headline.length >= 6){
            const regex = /[0-9]+ [A-Z][a-z]+; [0-9]+ [A-Z][a-z]+ - [0-9]+ (AM|PM);/gm;
            if(regex.test(dateTime)){                
                if(description.length >= 10){
                    if(imageUrl.startsWith('http://') || imageUrl.startsWith('https://')){
                        return true;
                    }
                }
            }
        }
    }
}

handlers.getMoreInfo = async function (ctx){    
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username'); 
    let userId = sessionStorage.getItem('id');

    const event = await eventService.getAEvent(ctx.params.id);
    event.isCreator = event._acl.creator === userId;
    ctx.event = event;

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
    }).then(function () {
    this.partial('../views/moreInfo.hbs');        
    }).catch(function (err) {
    notifications.showError('Cannot load More Information template');
    });
}

handlers.getEditView = async function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');
    
    const currentEvent = await eventService.getAEvent(ctx.params.id);  
    ctx.currentEvent = currentEvent;

    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
    }).then(function () {
        this.partial('../views/edit.hbs');        
    }).catch(function (err) {
        notifications.showError('Cannot load Edit Event template');
    });
}

handlers.editEvent = function (ctx){
    console.log('aaaaaaaa');
    /*ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');    

    let data = {...ctx.params, interestedPeople: 0, organizer: sessionStorage.getItem('username')};
console.log(data);
    if(isValid(data)){
        eventService.editEvent(data).then(() => {
            notifications.showSuccess('Event edited successfully.');
            ctx.redirect('#/home');
        }).catch(() => {
            notifications.showError('Cannot edit this cvent');
        });
    }else{
        notifications.showError('Cannot edit this event');
    }

    function isValid(data){
        const headline = data.headline;
        const dateTime = data.dateTime;
        const description = data.description;
        const imageUrl = data.imageURL;

        if(headline.length >= 6){
            const regex = /[0-9]+ [A-Z][a-z]+; [0-9]+ [A-Z][a-z]+ - [0-9]+ (AM|PM);/gm;
            if(regex.test(dateTime)){                
                if(description.length >= 10){
                    if(imageUrl.startsWith('http://') || imageUrl.startsWith('https://')){
                        return true;
                    }
                }
            }
        }
    }*/
}

handlers.getProfile = async function (ctx){
    ctx.isAuth = userService.isAuth();
    ctx.username = sessionStorage.getItem('username');
    ctx.id = sessionStorage.getItem('id'); 
    ctx.username = sessionStorage.getItem('username');
console.log(eventService.getEvents());
    ctx.loadPartials({
        header: '../views/common/header.hbs',
        footer: '../views/common/footer.hbs'
    }).then(function () {
        this.partial('../views/profile.hbs');        
    }).catch(function (err) {
        notifications.showError('Cannot load Profile template');
    });
}

handlers.getCreateEvent = function (ctx){
    ctx.redirect('#/organizeEvent');
}

handlers.removeEvent = function (ctx){
    console.log(ctx);
    eventService.removeEvent(ctx.params.id).then(function(){
        notifications.showSuccess('The song is removed successfully.');
        ctx.redirect('#/home');
    }).catch(function(err){
        notifications.showError(err.responseJSON.description);
    });
}

handlers.joinInTheEvent = async function (ctx) {
    const id = ctx.params.id;
    const event = await eventService.getAEvent(id);

    let newJoinedPeople = Number(event.interestedPeople) + 1;
    event.interestedPeople = newJoinedPeople;

    console.log(event);

    eventService.joinTheEvent(id, event).then(function(id, event){
        notifications.showSuccess('You join the event successfully.');
        ctx.redirect('#/home');
    }).catch(function(err) {
        notifications.showError(err.responseJSON.description);
    });
}