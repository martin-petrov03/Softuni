function solve(){
    let obj = {
        name: this.name,
        personalInfo: {
            age: this.age,
            weight: this.weight,
            height: this.height
        },
        BMI: this.BMI,
        status: this.status              
    };
    obj.name = arguments[0];
    obj.personalInfo.age = arguments[1];
    obj.personalInfo.weight = arguments[2];
    obj.personalInfo.height = arguments[3];
    
    let bmi = Math.round(+obj.personalInfo.weight / Math.pow(+obj.personalInfo.height/100, 2));
    let status = '';
    if(bmi < 18.5){
        status = 'underweight';
    }else if(bmi < 25){
        status = 'normal';
    }else if(bmi < 30){
        status = 'overweight';
    }else{
        status = 'obese';        
    }
    obj.BMI = bmi;
    if(status == 'obese'){
        obj.status = status;
        obj.recommendation = 'admission required';
    }else{
        obj.status = status;
    }
    return obj;

}
//console.log(solve("Peter", 29, 75, 182));
console.log(solve('Honey Boo Boo', 9, 57, 137));