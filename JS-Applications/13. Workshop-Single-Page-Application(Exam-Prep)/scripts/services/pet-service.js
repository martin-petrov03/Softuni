const petService = (() => {
    function createPet (data){
        return kinvey.post('appdata', 'pets', 'kinvey', data);
    }

    function getAll(filter){
        let query = filter && filter != 'All' 
        ? {category: filter} 
        : {};
        
        let endpoint = `pets?query=${JSON.stringify(query)}&sort={"likesCounter": -1}`;
        
        return kinvey.get('appdata', endpoint,'kinvey');
        
    }

    function getMyPets(userId){
        return kinvey.get('appdata', `pets?query={"_acl.creator":"${userId}"}`, 'kinvey');
    }

    function getDelete(userId){
        return kinvey.get('appdata', `pets?query={"_id":"${userId}"}`, 'kinvey');
    }

    function removePet(id){
        return kinvey.remove('appdata', `pets/${id}`,'kinvey');
    }

    function likePet(id, song){        
        return kinvey.update('appdata', `pets/${id}`,'kinvey', song);
    }

    function getAPet(id){
        return kinvey.get('appdata', `pets/${id}`,'kinvey');
    }
    
    return {
        createPet,
        getAll,
        getMyPets,
        getDelete,
        removePet,
        likePet,        
        getAPet        
      }
})()