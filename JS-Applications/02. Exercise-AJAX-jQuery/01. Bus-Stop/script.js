function getInfo() {    
    let id = $('#stopId').val();

    if((id === '1287' || id === '1308' || id === '1327' || id === '2334')){
        const url = `https://judgetests.firebaseio.com/businfo/${id}/name.json`;
        
        $.ajax({
            method: 'GET',
            url: url,
            success: (data) => {                
                $('#stopName').text(data);
                loadBuses(id);
            },
            error: (data) => {
                console.log('error');
            }
        });
        function loadBuses(id){
            $('#buses').empty();
            $('#stopName').val('');
            $('#stopId').val('');
            const urlBuses = `https://judgetests.firebaseio.com/businfo/`;
            
            $.ajax({
                method: 'GET',
                url: urlBuses + id + '.json',
                success: (data) => {
                    for(let [key, value] of Object.entries(data.buses)){                
                        let $li = $('<li>');
                        $li.text(`Bus ${+key} arrives in ${+value} minutes`);

                        $('#stopName').text(data.name);
                        $('#buses').append($li);
                    }
                },
                error: (data) => {
                    console.log('error');
                }
            });
        }            
    }else{
        $('#stopName').text('Error');
    }
}