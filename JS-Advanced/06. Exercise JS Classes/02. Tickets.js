function solve(arr, sortCriterion){
    class Ticket{
        constructor(destination, price, status){        
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }  
    let arrOfTickets = [];
    for(let i = 0; i < arr.length; i++){
        let line = arr[i].split('|');
        let destination = line[0];
        let price = +line[1];
        let status = line[2];
        let currentTicket = new Ticket(destination, price, status);
        arrOfTickets.push(currentTicket);
    }    
    return arrOfTickets = arrOfTickets.sort((a, b) => {
        if(a[sortCriterion] < b[sortCriterion]){
            return -1;
        } else if(a[sortCriterion] > b[sortCriterion]){
            return 1;
        }
        return 0;
    });
}
console.log(solve([
    'Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'status'
    ));