function solve() {  
   let buttons = document.getElementsByTagName('button');
		

	buttons[0].addEventListener('click', showMore1);
	buttons[1].addEventListener('click', showMore2);
   	buttons[2].addEventListener('click', showMore3);
   function showMore1(){      
         if(document.querySelectorAll('.profile input[type=radio]')[1].checked && document.querySelectorAll('.profile input[type=radio]')[1].value === 'unlock'){               
               document.querySelector('#user1HiddenFields').style.display = 'block';
               document.querySelector('.profile button').textContent = 'Hide it';
               let hideButton = document.querySelector('.profile button');
               hideButton.addEventListener('click', function(){
                  document.querySelector('#user1HiddenFields').style.display = 'none';
                  hideButton.textContent = 'Show more';
               });
         }   
   }
   function showMore2(){      
      if(document.querySelectorAll('.profile input[type=radio]')[3].checked && document.querySelectorAll('.profile input[type=radio]')[3].value === 'unlock'){               
            document.querySelector('#user2HiddenFields').style.display = 'block';
            let hideButton = buttons[1];
            hideButton.textContent = 'Hide it';
            hideButton.addEventListener('click', function(){
               document.querySelector('#user2HiddenFields').style.display = 'none';
               hideButton.textContent = 'Show more';
            });
      }   
   }
   function showMore3(){      
      if(document.querySelectorAll('.profile input[type=radio]')[5].checked && document.querySelectorAll('.profile input[type=radio]')[5].value === 'unlock'){               
            document.querySelector('#user3HiddenFields').style.display = 'block';                        
            let hideButton = buttons[2];
            hideButton.textContent = 'Hide it';
            hideButton.addEventListener('click', function(){
               document.querySelector('#user3HiddenFields').style.display = 'none';
               document.querySelector('.profile button').textContent = 'Show more';
            });
      }   
   }
} 