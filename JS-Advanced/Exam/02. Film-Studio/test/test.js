let FilmStudio = require('../filmStudio');
let assert = require('chai').assert;

describe("Tests FilmStudio functionality", function() {
    describe("test common functionality", function() {
        let film;
        beforeEach(function() {
            film = new FilmStudio('My-Studio');
        });
        it("should return []", function() {
            assert.deepEqual(film.films, []);
        });
        it("should return obj", function() {
            assert.deepEqual(new FilmStudio('Martin'), { name: 'Martin', films: [] });
        });
        it("should return obj", function() {
            assert.deepEqual(film.makeMovie('martin', ['a', 'b', 'c']), { filmName: 'martin',
            filmRoles:
             [ { role: 'a', actor: false },
               { role: 'b', actor: false },
               { role: 'c', actor: false } ] });
        });
        it("should return message", function() {
            assert.deepEqual(film.casting('martin', 'a'), 'There are no films yet in My-Studio.');
        });
        it("should return message", function() {
            film.makeMovie('martin', ['a', 'b', 'c'])

            assert.deepEqual(film.casting('martin', 'z'), 'martin, we cannot find a z role...');
        });
        it("should return message", function() {
            film.makeMovie('martin', ['a', 'b', 'c']);
            assert.deepEqual(film.casting('martin', 'a'), 'You got the job! Mr. martin you are next a in the martin. Congratz!');
        });
        it("should return message", function() {
            film.makeMovie('martin', ['a', 'b', 'c']);
            film.makeMovie('martin', ['a', 'b', 'c', 'z']);
            assert.deepEqual(film.casting('martin 2', 'z'), 'You got the job! Mr. martin 2 you are next z in the martin 2. Congratz!');       
        });
        it("should print message", function() {
            film.makeMovie('martin', ['a', 'b', 'c']);          
            assert.deepEqual(film.lookForProducer('martin'), 'Film name: martin\nCast:\nfalse as a\nfalse as b\nfalse as c\n');
            //Film name: martin\nCast:\nfalse as a\nfalse as b\nfalse as c\n
        });
        it("should print message", function() {
            film.makeMovie('martin', ['a', 'b', 'c']);
            film.casting('martin', 'a'); 
            assert.deepEqual(film.lookForProducer('martin'), 'Film name: martin\nCast:\nmartin as a\nfalse as b\nfalse as c\n');
            //Film name: martin\nCast:\nmartin as a\nfalse as b\nfalse as c\n
        });
        it("should print message", function() {
            film.makeMovie('martin', ['a', 'b', 'c']);
            film.casting('martin', 'a');
            film.casting('pesho', 'b');
            film.casting('sasho', 'c'); 
            assert.deepEqual(film.lookForProducer('martin'), 'Film name: martin\nCast:\nmartin as a\npesho as b\nsasho as c\n');
            //Film name: martin\nCast:\nmartin as a\nfalse as b\nfalse as c\n
        });
        it("should print message", function() {            
            assert.throw(function(){film.lookForProducer('martin')}, 'martin do not exist yet, but we need the money...');
            //Film name: martin\nCast:\nmartin as a\nfalse as b\nfalse as c\n
        });
     });
     describe("test makeMovie with edge cases", function() {
        let film;
        beforeEach(function() {
            film = new FilmStudio('My-Studio');
        });        
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie('martin', ['a', 'b', 'c'], 'ad')}, 'Invalid arguments count');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie('martin', 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie('martin',[], 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie(2121.12, 'martin',[], 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie([], 2121.12, 'martin',[], 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie({}, 2121.12, 'martin',[], 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie({dsad:'dad'},2121.12, 'martin',[], 1)}, 'Invalid arguments');
        });
        it("should throw error", function() {            
            assert.throw(function(){film.makeMovie(()=>{},2121.12, 'martin',[], 1)}, 'Invalid arguments');
        });
        it("should return obj", function() {            
            assert.deepEqual(film.makeMovie('martin',[]), { filmName: 'martin', filmRoles: [] });
        });
        it("should return obj", function() {
            film.makeMovie('martin',[]);    
            assert.deepEqual(film.makeMovie('martin',[]), { filmName: 'martin 2', filmRoles: [] });
        });
        it("should throw error", function() {            
            let film = new FilmStudio('My-Studio');
            film.makeMovie('martin',['aaaa', 'asd']); 
            assert.deepEqual(film.makeMovie('martin',['121212122']), { filmName: 'martin 2',
            filmRoles: [ { role: '121212122', actor: false } ] });
        });
     });

});
