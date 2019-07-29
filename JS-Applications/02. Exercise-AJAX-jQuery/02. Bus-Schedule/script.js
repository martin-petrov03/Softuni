function solve() {
    let next = 'depot';
    let currentStop;
    function depart(){
      const url = `https://judgetests.firebaseio.com/schedule/${next}.json`;
        $.ajax({
            method: 'GET',
            url,            
            success: (data) => {
              $('.info').text(`Next stop ${data.name}`);
              $('#depart').attr('disabled', true);
              $('#arrive').attr('disabled', false);
              next = data.next;
              currentStop = data.name;
          },
          error: (data) => {
            $('.info').text(`Error`);
            $('#depart').attr('disabled', true);
            $('#arrive').attr('disabled', true);
          }
        });
    }
    function arrive(){
      const url = `https://judgetests.firebaseio.com/schedule/${next}.json`;
        $('.info').text(`Arriving at ${currentStop}`);
        $('#depart').attr('disabled', false);
        $('#arrive').attr('disabled', true);
    }
    return {
      depart,
      arrive
    };
  }
  let result = solve();