function solve() {    
    let output = document.getElementById('output');
    let button = document.getElementsByTagName('button')[0].addEventListener('click', extract);

    function extract(){
        let string = document.getElementById('input').value;      
        let regex = /[0-9]+/gm;
        let count = string.match(regex)[0];   
        let splicedString = string.substr(count.length, Number(count));

        let spliter = splicedString[splicedString.length - 1];
        let inputArr = splicedString.split(spliter).filter(Boolean);
        let pattern = inputArr[0];
        let secondPart = inputArr[1];
        let regexPattern = '[' + pattern + ']';
        secondPart = secondPart.replace(new RegExp(regexPattern, 'g'), "");
        let result = secondPart.replace(/[#]/g, ' ');    
        output.value = result;          
    }
}