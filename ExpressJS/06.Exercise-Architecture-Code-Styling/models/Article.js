const mongoose = require('mongoose');

let articleSchema = mongoose.Schema({
    title: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    content: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    author: {
        type: mongoose.Schema.Types.ObjectId,
        required: true,
        ref: 'User',
        unique: true
    },
    date: {
        type: mongoose.Schema.Types.Date,
        default: Date.now
    }
});

module.exports = mongoose.model('Article', articleSchema);