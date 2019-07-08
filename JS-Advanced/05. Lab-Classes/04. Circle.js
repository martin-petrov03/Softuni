class Circle{
    constructor(radius){
        this.radius = radius;        
    }
    
    //getters and setters    
    get diameter (){
        return this.radius * 2;
    }
    set diameter(diameter){
        this.radius = diameter / 2;
    }
    get area (){
        return Math.pow(this.radius, 2) * Math.PI;
    }
    set area(area){
        this.area = area;
    }
}
let c = new Circle(2);
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);
c.diameter = 1.6;
console.log(`Radius: ${c.radius}`);
console.log(`Diameter: ${c.diameter}`);
console.log(`Area: ${c.area}`);