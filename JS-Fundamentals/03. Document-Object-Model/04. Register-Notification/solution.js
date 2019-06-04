function register() {
      let username = document.querySelector('#username').value;
      let email = document.querySelector('#email').value;
      let password = document.querySelector('#password').value;
      
      let regex = new RegExp("^(.+)@(.+).(com|bg)", "gm");
      
      if(username !== '' && username !== ' ' && regex.exec(email) && password !== '' && password !== ' '){
          let resultDiv = document.querySelector('#result');        
          let titleElement = document.createElement('h1');
          titleElement.textContent = "Successful Registration!";          
          let usernameElement = document.createElement('p');
          usernameElement.textContent = `Username: ${username}`;
          let emailElement = document.createElement('p');
          emailElement.textContent = `Email: ${email}`;
          let passwordElement = document.createElement('p');
          passwordElement.textContent = `Password: ${'*'.repeat(password.length)}`;          
          
          let newLine = document.createElement('br');
          
          resultDiv.appendChild(titleElement);
          resultDiv.appendChild(newLine);
          resultDiv.appendChild(usernameElement);
          resultDiv.appendChild(emailElement);
          resultDiv.appendChild(passwordElement);
      }
      document.getElementById("username").value = "";
      document.getElementById("email").value = "";
      document.getElementById("password").value = "";
}