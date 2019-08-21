function solve(){
    let obj = {
        extend: function(template) {
            const entries = Object.entries(template);
            for(let [key, value] of entries){
                if(typeof value === 'function'){
                    Object.getPrototypeOf(this)[key] = value;// this means template                                    
                }else{
                    this[key] = value;
                }
            }
        }
    };
    return obj;
}
let obj = solve();
obj.extend({
    extensionMethod: function () {console.log('faf')},
    extensionProperty: 'someString'
  });
  console.log(obj);