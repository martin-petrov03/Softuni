const mongoose = require('mongoose');

const teamSchema = new mongoose.Schema({
    name: { type: mongoose.Schema.Types.String, required: true, unique: true },    
    projects: { type: mongoose.Schema.Types.Array },
    members: [{ type: mongoose.Schema.Types.Array }]
});

const Team = mongoose.model('Team', teamSchema);
module.exports = Team;