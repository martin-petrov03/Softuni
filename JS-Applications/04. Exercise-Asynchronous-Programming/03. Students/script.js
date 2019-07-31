  function solve(){
    //config
        let url = 'https://baas.kinvey.com/appdata/';
        let appKey = "kid_BJXTsSi-e";    

        let postUrl = url + appKey + '/students';
        
        let headers = {
            'Authorization': 'Basic ' + btoa('guest:guest'),
            "Content-Type": "application/json"
        };


        $('#addBtn').click(createStudent);
        $('#loadBtn').click(loadStudents);

        async function createStudent() {
            $('fieldset span').text('');
            let idInput = $('#studentID');
            let firstName = $('#firstName');
            let lastName = $('#lastName');
            let faciltyNumber = $('#facultyNumber');
            let gradeInput = $('#grade');

            let id = Number(idInput.val());
            let grade = Number(gradeInput.val());

            let facyltyregex = /^\d+$/g;

            if (idInput.val() != "" &&
                firstName.val() != "" &&
                lastName.val() != "" &&
                facyltyregex.test(faciltyNumber.val()) &&
                gradeInput.val() != "") {
                let student = {
                    ID:id,
                    FirstName: firstName.val(),
                    LastName: lastName.val(),
                    FacultyNumber: faciltyNumber.val(),
                    Grade: grade

                };
                
                if(grade >= 2 && grade <= 6){
                    try{
                        await $.ajax({
                            url: postUrl,
                            method: 'POST',
                            headers,
                            data: JSON.stringify(student)
                        });
                        
                        $('fieldset span').text('');
                        loadStudents();
                    }
                    catch(err){
                        console.log(err);
                    }
                }else{
                    $('fieldset').append('<span>Invalid Grade</span>');
                }
                idInput.val('');
                firstName.val('');
                lastName.val('');
                faciltyNumber.val('');
                gradeInput.val('');
            }else{
                $('fieldset').append('<span>Invalid Input</span>');
            }
        }

    async function loadStudents(){
        try{           
            let students = await $.ajax({
                method: 'GET',
                url: postUrl,
                headers
            });
            
            students = students.sort((a, b)=> {
                return a.ID - b.ID;
            });

            for (let student of students) {                
                let $currentUser = $(`
                    <tr>
                        <td>${student.ID}</td>
                        <td>${student.FirstName}</td>
                        <td>${student.LastName}</td>
                        <td>${student.FaciltyNumber}</td>
                        <td>${student.Grade}</td>
                    </tr>
                `);
                $('#results').append($currentUser);
            }              
        } catch(err){
            console.log(err);
        }
    }    
}