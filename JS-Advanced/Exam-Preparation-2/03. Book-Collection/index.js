class BookCollection{    
    constructor(shelfGenre, room, shelfCapacity){
        this.room = room;
        this.shelfGenre = shelfGenre;
        this.shelfCapacity = shelfCapacity;
        this.shelf = [];
        this.shelfCondition = shelfCapacity - this.shelf.length;
        return this;               
    }
    get room(){
        return this._room;
    }
    set room(value){
        if(value === 'livingRoom' || value === 'bedRoom' || value === 'closet'){
            this._room = value;
        }else{            
            throw(`Cannot have book shelf in ${room}`);
        }
    }

    get shelfCondition(){
        return this._shelfCondition;
    }
    set shelfCondition(shelfCondition){
        this._shelfCondition = shelfCondition;
    }
    
    addBook(bookName, bookAuthor, genre){      
        if(this.shelfCapacity - this.shelf.length <= 0){
            this.shelf.shift();         
        }
        let book = {bookName, bookAuthor, genre};
        this.shelf.push(book);
        this.shelf.sort((a, b) => a.bookAuthor.localeCompare(b.bookAuthor));
        return this;
    }
    throwAwayBook(bookName){
       for(let i = 0; i < this.shelf.length; i++){        
        if(this.shelf[i].bookName === bookName){
                this.shelf.splice(i, 1);
           }
       }       
       return this;
    }
    toString(){
        if(this.shelf.length === 0){
            return 'It\'s an empty shelf';
        }
        let output = `${this.shelfGenre} shelf in ${this.room} contains:`;
        let lines = [];
        for(let obj of this.shelf) {
            let line = `\uD83D\uDCD6 ${obj.bookName} - ${obj.bookAuthor}`;
            lines.push(line);        
        }        
        for(let i = 0; i < lines.length; i++){
            output += '\n';
            if(i == lines.length - 1){
                output += lines[i];
                continue; 
            }
            output += lines[i];            
        }
        return output;
    }
    showBooks(genre){
        let results = [];
        for(let obj of this.shelf){
            if(obj.genre === genre){
                results.push(obj);
            }
        }        
        let output = `Results for search "${genre}":`;
        let lines = [];
        for(let obj of this.shelf) {
            let line = `\uD83D\uDCD6 ${obj.bookAuthor} - ${obj.bookName}`;
            lines.push(line);
        }        
        for(let i = 0; i < results.length; i++){
            output += '\n';
            output += lines[i];            
        }
        return output;
    }
}
let bedRoom = new BookCollection('Mixed', 'bedRoom', 5);
bedRoom.addBook("John Adams", "David McCullough", "history");
bedRoom.addBook("The Guns of August", "Cuentos para pensar", "history");
bedRoom.addBook("Atlas of Remote Islands", "Judith Schalansky");
bedRoom.addBook("Paddle-to-the-Sea", "Holling Clancy Holling");
console.log("Shelf's capacity: " + bedRoom.shelfCondition);
console.log(bedRoom.showBooks("history"));
