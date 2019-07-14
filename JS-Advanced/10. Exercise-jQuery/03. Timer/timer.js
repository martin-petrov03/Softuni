function timer() {
   $('#start-timer').click(start);
   $('#stop-timer').click(stop);

   //select spans
   let hoursSpan = $('#hours');
   let minutesSpan = $('#minutes');
   let secondsSpan = $('#seconds');   
   
   $('#start-timer').click(function(){
      startTimer();
   });
   
   let timer;
   //call function evry second
   function startTimer(){      
      timer = setInterval(start, 1000);
   }
   let currentSeconds = +secondsSpan.text() - 1;
   let currentMinutes = 0;
   let currentHours = 0;
   //difine start function
   function start(){
      $('#start-timer').attr('disabled', true);
      
      currentSeconds += 1;
      /*let formatedSeconds = '00';
      let formatedMinutes = '00';
      let formatedHours = '00';

      if(currentSeconds < 10){
         formatedSeconds = `0${currentSeconds}`;
      }else if(currentSeconds >= 10 && currentSeconds <= 59){
         formatedSeconds = currentSeconds;
      }else {         
         currentMinutes += 1;
         currentSeconds = 0;
         if(currentMinutes < 10){
            formatedMinutes = '0' + currentMinutes;
         }else if(currentMinutes >= 10 && currentMinutes <= 59){
            formatedMinutes = currentMinutes;
         }else{
            currentHours += 1;
            currentMinutes = 0;
            currentSeconds = 0;
            if(currentHours < 10){
               formatedHours = '0' + currentHours;
            }else if(currentHours >= 10 && currentHours <= 59){
               formatedHours = currentHours;
            }else{
               alert('Too Much!');
            }
            hoursSpan.text(formatedHours);
         }
         minutesSpan.text(formatedMinutes);
      }
      secondsSpan.text(formatedSeconds);*/
      if(currentSeconds === 60){
         currentSeconds = 0;
         currentMinutes += 1;
      } else if(currentMinutes === 60){         
         currentHours += 1;
         currentMinutes = 0;       
      }
      if(currentSeconds < 10){
         let formated = `0${currentSeconds}`;
         secondsSpan.text(formated);    
      }else{
         secondsSpan.text(currentSeconds);
      }
      if(currentMinutes < 10){
         let formated = `0${currentMinutes}`;
         minutesSpan.text(formated);
      }else{
         minutesSpan.text(currentMinutes);
      }
      if(currentHours < 10){
         let formated = `0${currentHours}`;
         hoursSpan.text(formated);
      }else{
         hoursSpan.text(formatedHours);
      }      
   }
   //define stop function
   function stop(){
      currentSeconds -= 1;
      clearInterval(timer);
      $('#start-timer').attr('disabled', false);
   }
}