let pesho = {
    name: 'Pesho',
    age: 15,
    city: 'Sofia'
};

let me = Object.create(pesho);
me.name = 'Martin';

if(me.hasOwnProperty('name')){
    console.log(me.name);
}else{
    console.log('I haven\'t got property name, but my prototype pesho has' + me.age);
}

//me hasn't got property age and it will display pesho age because pesho is property of me
console.log(me.age);
console.log(me.city);