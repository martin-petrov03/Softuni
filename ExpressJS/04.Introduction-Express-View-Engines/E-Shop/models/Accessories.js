const mongoose = require('mongoose');
const { Schema } = mongoose; 

const accessoriesSchema = new Schema({
    name: { type: String, required: true, minlength: 3, maxlength: 15 },
    description: { type: String, required: true,  minlength: 20, maxlength: 300 },
    imageUrl: { type: String, required: true },
    difficulty: { type: Number, required: true, min: 1, max: 10 },
    accessories: [{ type: mongoose.Types.ObjectId, ref: 'Cube' }]
});

module.exports = mongoose.model('Accessories', accessoriesSchema);