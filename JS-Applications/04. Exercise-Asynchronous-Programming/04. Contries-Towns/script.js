    const appKey = 'kid_rJNRV3yY4';
    const baseUrl = `https://baas.kinvey.com/appdata/${appKey}/Countries`;
    const headers = {
        'Authorization': 'Basic ' + btoa('guest:guest'),
        "Content-Type": "application/json"
    };

    $('#loadBtn').on('click', load);
    $('#createBtn').on('click', create);

    async function load(){
        let coontries = [];
        try{
            let countries = await $.ajax({
                url: baseUrl,
                method: 'GET',
                headers
            });

            $('#countries').text('');
            let $outputDiv = $('#countries'); 
            for(let country of countries){                
                let $currentCountry = $(`<p>${country.value}</p>`);
                $outputDiv.append($currentCountry);
            }            
        }
        catch(err){
            $('body').append(`<span style="color: red; font-size: 30px">${err}</span>`);
        }
    }
    async function create(){
        let country = $('#country').val();
        try{
            let currentCountry = await $.ajax({
                url: baseUrl,
                method: 'POST',
                headers,
                data: JSON.stringify({
                    value: country
                })
            });            
        }catch(err){
            $('body').append(`<span style="color: red; font-size: 30px">${err}</span>`);
        }
        $('#country').val('');
    }