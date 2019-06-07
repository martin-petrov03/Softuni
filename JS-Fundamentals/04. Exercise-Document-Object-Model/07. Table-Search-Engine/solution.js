function solve() {
    let buttons = document.getElementsByTagName('button');	
    buttons[0].addEventListener('click', search);
    function search(){
        let input = document.getElementById('searchField');
        
        let table = document.getElementsByTagName("table");
        let tr = table[0].getElementsByTagName("tr");
        for(let i = 0; i < tr.length; i++){
            let td = table[0].getElementsByTagName("td");
            if(td[0] === input){
                console.log('a');
            }
        }
    }	
}