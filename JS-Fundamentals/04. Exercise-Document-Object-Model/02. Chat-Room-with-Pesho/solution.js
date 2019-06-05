function solve() {
   let buttons = Array.from(document.getElementsByTagName('button'));
   let inputFields = Array.from(document.getElementsByTagName('input'));
   buttons.forEach((btn) =>{
       btn.addEventListener('click', function (event){           
            let divElement = document.createElement('div');
            let spanElement = document.createElement('span');
            let pElement = document.createElement('p');

            let senderBtn = event.target.name;
            console.log(event.target);
            if(senderBtn === 'myBtn' && inputFields[0] !== ''){
                spanElement.textContent = 'Me';
                pElement.textContent = document.getElementById('myChatBox').value;              
            } else if(senderBtn === 'peshoBtn' && inputFields[1] !== ''){
                spanElement.textContent = 'Pesho';
                pElement.textContent = document.getElementById('peshoChatBox').value;                
            }
            divElement.appendChild(spanElement);
            divElement.appendChild(pElement);
            let chatMessages = document.getElementById('chatChronology');
            chatMessages.appendChild(divElement);
            inputFields[0].value = '';
            inputFields[1].value = '';
       })
   })
}