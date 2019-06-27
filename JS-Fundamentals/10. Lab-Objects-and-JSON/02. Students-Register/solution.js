document.getElementById("button").addEventListener("click", function(event){
    event.preventDefault()
});
function addStudents() {
    let students = document.getElementById('input').value.split('\n');    
    let result = [];
    for(let student of students){
        let info = student.split(' ');        
        let obj = {};
        let objKey = info[0];
        let objValue = info[1];
        obj[objKey] = objValue;
        result.push(obj); 
    }
    let resultElement = document.getElementById('result');
    
    for(let el of result){       
        resultElement.innerHTML += JSON.stringify(el);
        console.log(el);
    }
    
}