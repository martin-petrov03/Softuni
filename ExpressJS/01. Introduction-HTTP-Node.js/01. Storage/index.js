const storage = require('./storage');

storage.put('name', 'pesho');
storage.put('age', 12);

storage.save();
storage.load();