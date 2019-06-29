function solve() {   
    let buttons = document.getElementsByTagName('button');    
    let submitButton = buttons[0];
    let searchButton = buttons[1];
    submitButton.addEventListener('click', submit);
    searchButton.addEventListener('click', search);

    function submit(event){
        event.preventDefault();        
        //let password = document.getElementsByClassName('user-info')[0].children[1].value;
        let user = {
            username: document.getElementsByClassName('user-info')[0].children[1].value,
             email: document.getElementsByClassName('user-info')[0].children[5].value,
              topics:Array.from(document.getElementsByClassName('topics')[0].children).filter(el => el.checked).map(el => el.value)
        };
        
        let trElement = document.createElement('tr');

        let tdUsername = document.createElement('td');
        tdUsername.innerHTML = user.username;
        let tdEmail = document.createElement('td');
        tdEmail.innerHTML = user.email;
        let tdTopics = document.createElement('td');
        tdTopics.innerHTML = user.topics.join(' ');
        trElement.appendChild(tdUsername);
        trElement.appendChild(tdEmail);
        trElement.appendChild(tdTopics);
        document.getElementsByTagName('tbody')[0].appendChild(trElement);        
    }
    function search(){
        let searchedString = document.getElementsByTagName('input')[7].value;

        let tds = Array.from(document.querySelectorAll('table tbody tr td'));
        for(let td of tds){
            td.parentNode.style.visibility = 'hidden';            
        }
        for(let td of tds){
            if(td.textContent.includes(searchedString)){
                td.parentNode.style.visibility = 'visible';
            }
        }
        
    }
}