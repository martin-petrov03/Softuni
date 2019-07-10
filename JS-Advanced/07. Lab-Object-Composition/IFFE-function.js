let calculator = (function(){
    //closure
    let num = 0;
    function increase(increaseNum){
        num += increaseNum;
    }
    function decrease(decreaseNum){
        num -= decreaseNum;
    }
    function toString(){
        console.log(num);
    }
    return{increase, decrease, toString};
})();
calculator.decrease(2);
calculator.toString();
