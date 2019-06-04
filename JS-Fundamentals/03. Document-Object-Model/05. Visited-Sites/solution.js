function solve() {   
  //Gmail
    let gmailLink = document.getElementById('gmail');
    let countGmailVisit = 5;
    gmailLink.onclick = function() {
      countGmailVisit += 1;      
      let textGmailVisit = `Visited: ${countGmailVisit} times`;
      let gmailVisit = document.getElementById('countVisitGmail');
      gmailVisit.textContent = textGmailVisit;
    };  
}