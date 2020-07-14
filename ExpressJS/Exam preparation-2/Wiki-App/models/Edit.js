const mongoose = require('mongoose');

const editSchema = new mongoose.Schema({
    author: {
        type: mongoose.Schema.Types.ObjectId,
        ref: 'User',
        required: true     
    },
    content: { 
        type: mongoose.Schema.Types.String,
        required: true
    },
    creationDate: { 
        type: mongoose.Schema.Types.Date, 
        default: Date.now 
    },
    article: {
        type: mongoose.Schema.Types.ObjectId,
        ref: 'Article'
    }
});

const Edit = mongoose.model('Edit', editSchema);

module.exports = Edit;