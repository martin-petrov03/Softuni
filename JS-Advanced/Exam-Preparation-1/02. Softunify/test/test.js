const SoftUniFy = require('../02. Softunify');
const assert = require('chai').assert;
const expect = require('chai').expect;

describe("test general functionality", function() {
    let soft;
    beforeEach(function(){
        soft = new SoftUniFy();
    });
    it("contains allSongs", function() {    
        expect(soft.allSongs).to.eql({});
    });    
});
describe("test downloadSong functionality", function() {        
    it("should return array with current values", function() {
        let song = new SoftUniFy().downloadSong('me', 'songName', 'love');
        expect(song.allSongs['me']['songs']).to.eql(['songName - love']);        
    });    
});
describe("test playSong functionality", function() {
    it("contains current song", function() {
        let current = new SoftUniFy().downloadSong('me', 'songName', 'love');
        
        expect(current.playSong('songName')).to.eql('me:\nsongName - love\n');
    });
});
describe("test songsList functionality", function() {
    it("contains current song", function() {
        let current = new SoftUniFy();
        current.downloadSong('me', 'songName', 'love');      
        expect(current.songsList()).to.be.equal('');      
    });
    it("return error message", function() {
        expect(new SoftUniFy().songsList().length == 0).to.be.equal('Your song list is empty');   
    });    
});
