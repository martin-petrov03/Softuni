const fs = require('fs');
let storage = {};

function put(key, value){
    if(typeof key !== 'string'){
        throw ('The key should be a string');
    }
    if(storage.hasOwnProperty(key)){
        throw ('The key should be unique');
    }

    storage[key] = value;
}

function get(key){
    if(typeof key !== 'string'){
        throw ('The key should be a string');
    }

    if(!storage.hasOwnProperty(key)){
        throw ('The storage doesn\'t contain the key');
    }

    return storage[key];
}

function getAll() {
    let storageArr = Object.entries(storage);

    if(storageArr.length == 0){        
        return 'There are no items in the storage';
    }
    return JSON.stringify(storage);    
}

function update(key, newValue) {
    if(typeof key !== 'string'){
        throw ('The key should be a string');
    }

    if(!storage.hasOwnProperty(key)){
        throw ('The storage doesn\'t contain the key');
    }
    
    storage[key] = newValue;
}

function deleteByKey(key) {
    if(typeof key !== 'string'){
        throw ('The key should be a string');
    }

    if(!storage.hasOwnProperty(key)){
        throw ('The storage doesn\'t contain the key');
    }
    
    delete storage[key];
}

function clear(){
    storage = {};
}

function save() {
    fs.writeFileSync('storage.json', JSON.stringify(storage), "utf-8");
}

function load(){
    if(fs.existsSync('storage.json')){        
        let storedStorage = fs.readFileSync('storage.json');
        storage = JSON.parse(storedStorage);
    }
}

const obj = {    
    put,
    get,
    getAll,
    update,
    deleteByKey,
    clear,
    save,
    load
};
module.exports = obj;