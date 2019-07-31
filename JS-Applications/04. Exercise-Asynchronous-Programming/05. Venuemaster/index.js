function attachEvents(){
    const appKey = 'kid_BJ_Ke8hZg';
    const baseUrl = "https://baas.kinvey.com/";
    const headers = {
        'Authorization': 'Basic ' + btoa('guest:guest'),
        "Content-Type": "application/json"
    };
    let base64Auth = btoa("guest:pass");
    $('#getVenues').click(getVenues);

    async function getVenues(){
        let venue = $('#venueDate').val();

        let freeVenues = await $.ajax({
            url: baseUrl + "rpc/" + appKey + "/custom/calendar?query=" + venue,
            method: "POST",
            headers : {
                "Authorization": "Basic " + base64Auth
            }
        });
        console.log(freeVenues);
    }
}