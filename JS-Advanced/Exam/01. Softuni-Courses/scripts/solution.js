 function solve(){    
 	$("#availableCourses .courseFoot").click(function(){
        const courses = [];
        $.each($("input[type='checkbox']:checked"), function(){  
            courses.push($(this).val());
        });        
        $( "#myCourses .courseBody ul" ).empty();
        let price = 0;
        courses.map(course => {
        	$('#myCourses .courseBody ul').append(`<li>${course}</li>`);
        	if(course == 'js-fundamentals'){
        		price += 100;
        	} else if(course == 'js-advanced'){
        		price += 200;
        	} else if(course == 'js-applications'){
        		price += 300;
        	} else if(course == 'js-web'){
        		price += 500;
        	}
        });
        if($('#educationForm input[value="onsite"]').is(":checked")){
        	price += courses.length * 50;
        }
        $('#myCourses .courseFoot p').text(`Cost: ${price.toFixed(2)} BGN`);
    });
 }
 solve();