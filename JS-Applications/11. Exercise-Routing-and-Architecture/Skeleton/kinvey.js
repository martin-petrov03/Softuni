const kinvey = (() => {
    const baseUrl = 'https://baas.kinvey.com/';
    const appKey = 'kid_r1IzOijYE';
    const appSecret = '0d98d477130c41c09a5d96492ef995f7';

    function makeAuth(auth) {
        if (auth == 'basic') {
          return {
            'Authorization': `Basic ${btoa(appKey + ':' + appSecret)}`
          }
        } else {
          return {
            'Authorization': `Kinvey ${sessionStorage.getItem('authtoken')}`
          }
        }
      }
    
      function makeRequest(method, collection, endpoint, auth) {          
        return {
          url: baseUrl + collection + '/' + appKey + '/' + endpoint,
          method,
          headers: makeAuth(auth)          
        }
      }
    
      function post(collection, endpoint, auth, data) {
        let request = makeRequest('POST', collection, endpoint, auth);
        request.data = data;
        return $.ajax(request);
      }

      function get(collection, endpoint, auth) {
        return $.ajax(makeRequest('GET', collection, endpoint, auth));
      }
    
      function update(collection, endpoint, auth, data) {
        let req = makeRequest('PUT', collection, endpoint, auth);
        req.data = data;
        return $.ajax(req);
      }
    
      function remove(collection, endpoint, auth) {
        return $.ajax(makeRequest('DELETE', collection, endpoint, auth));
      }

    return {
        get, post, update, remove
    }
})();