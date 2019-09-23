const eventService = (() => {
    function getEvents() {
        return kinvey.get('appdata', 'events','kinvey');
    }

    function createEvent(data){
        return kinvey.post('appdata', 'events', 'kinvey', data);
    }

    function getAEvent(id){
        return kinvey.get('appdata', `events/${id}`, 'kinvey');
    }

    function editEvent(data){
        return kinvey.update('appdata', `events`, 'kinvey', data);
    }
    
    function removeEvent(id){
        return kinvey.remove('appdata', `events/${id}`,'kinvey');
    }

    function joinTheEvent(id, event){
        return kinvey.update('appdata', `songs/${id}`,'kinvey', event);
    }

    return {
        getEvents,
        createEvent,
        getAEvent,
        editEvent,
        removeEvent,
        joinTheEvent
    }
})()