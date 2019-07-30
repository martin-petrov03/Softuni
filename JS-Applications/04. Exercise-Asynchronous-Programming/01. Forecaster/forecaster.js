function attachEvents(){
    $('#submit').click(function(){
        let city = $('#location').val();
        if(city == 'London' || city == 'New York' || city == 'Barcelona'){             
            configDom();
            const symbols = {
                'sunny': '&#x2600',
                'partly sunny': '&#x26C5',
                'overcast': '&#x2601',
                'rain': '&#x2614'                    
            };
            let code;
            getWeather();
            
            async function getWeather(){
                let baseUrl = 'https://judgetests.firebaseio.com/';
                try{
                    let weather = await $.ajax({
                        url: baseUrl + 'locations.json',
                        method: 'GET'
                    });
                    for(let obj of weather){
                        if(obj.name === city){     
                            code = obj.code;
                            break;
                        }
                    }

                    let locationWeather = await $.ajax({
                        url: baseUrl + `forecast/today/${code}.json`,
                        method: 'GET'
                    });
                    
                    let nextThreeDaysWeather = await $.ajax({
                        url: baseUrl + `forecast/upcoming/${code}.json`,
                        method: 'GET'
                    });
                    renderTodayForecast(locationWeather);
                    renderNextThreeDaysForecasts(nextThreeDaysWeather);
                }
                catch(err){
                    renderError();
                }
            }

            function renderTodayForecast(forecast){                console.log(forecast);
                let $span = $('<span class="condition">');
                $span.append(`
                <span class="forecast-data">${forecast.name}</span>
                
                <span class="forecast-data">${forecast.forecast.high}&#176/${forecast.forecast.low}&#176</span>
                
                <span class="forecast-data">${forecast.forecast.condition}</span>`);
                
                $('#current').append(`<span class="condition symbol">${symbols[forecast.forecast.condition.toLowerCase()]}</span>`);
                $('#current').append($span);
            }

            function renderNextThreeDaysForecasts(forecasts){
                for(let forecast of forecasts.forecast){
                    let $nextDayForecastSpanElement = $('<span class="upcoming">');

                    let $symbolSpan = $(`<span class="symbol">${symbols[forecast.condition.toLowerCase()]}</span>`);
                    let $degreesSpan = $(`<span class="forecast-data">${forecast.high}&#176/${forecast.low}&#176</span>`);
                    let $conditionSpan = $(`<span class="forecast-data">${forecast.condition}</span>`);

                    $nextDayForecastSpanElement.append($symbolSpan);$nextDayForecastSpanElement.append($degreesSpan);
                    $nextDayForecastSpanElement.append($conditionSpan);
                    $('#upcoming').append($nextDayForecastSpanElement);
                }
                
            }
        }else{
            renderError();
        }        
        function configDom(){
             //config DOM
             $('#forecast').css('display', 'inline-block');
             $('#forecast').html(`
                <div id="current">
                    <div class="label">Current conditions</div>
                </div>
                <div id="upcoming">
                    <div class="label">Three-day forecast</div>
                </div>`);             
        }
        function renderError(){
            $('#forecast').text('Error');
        }
    });

}