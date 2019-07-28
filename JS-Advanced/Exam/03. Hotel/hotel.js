class Hotel{
    constructor(name, capacity){
        this.name = name;
        this.capacity = capacity;
        this.bookings = [];
        this.currentBookingNumber = 1;
        this.singleRoomsCount = parseInt(capacity / 2);
        this.doubleRoomsCount = parseInt(30/100 * capacity);
        this.maisonetteCount = parseInt(20/100 * capacity);
        this.services = [];
    }
    roomsPricing(){
        let obj = {single: 50,double: 90, maisonette: 135};
        return obj;
    }
    servicesPricing(){
        let obj = {food: 10,drink: 15, housekeeping: 25};
        return obj;
    }
    rentARoom(clientName, roomType, nights){
        let obj = {};
        if(roomType == 'single' && this.singleRoomsCount > 0){
            this.singleRoomsCount--;            
        }else if(roomType == 'double' && this.doubleRoomsCount > 0){
            this.doubleRoomsCount--;
        }else if(roomType == 'maisonette' && this.maisonetteCount > 0){
            this.maisonetteCount--;
        }else{
            let line = '';
            if(roomType == 'single' || roomType == 'double' || roomType == 'maisonette'){
                line += `No ${roomType} rooms available!`;
                if(roomType == 'single'){
                    line += ` Available double rooms: ${this.doubleRoomsCount}.`;
                    line += ` Available maisonette rooms: ${this.maisonetteCount}.`;
                }else if(roomType == 'double'){
                    line += ` Available single rooms: ${this.singleRoomsCount}.`;
                    line += ` Available maisonette rooms: ${this.maisonetteCount}.`;
                }else{
                    line += ` Available single rooms: ${this.singleRoomsCount}.`;
                    line += ` Available double rooms: ${this.doubleRoomsCount}.`;
                }
            }
            return line;
        }
        
        if(this.bookings.length > 0){
            this.currentBookingNumber++;
        }            
        
        let currentBookingNumber = this.currentBookingNumber;
        obj = {clientName, roomType, nights, currentBookingNumber};
        this.bookings.push(obj);
        //this.currentBookingNumber = this.bookings.length + 1;
        return `Enjoy your time here Mr./Mrs. ${clientName}. Your booking is ${this.currentBookingNumber}.`;
    }
    roomService(currentBookingNumber, serviceType){      
        if(this.currentBookingNumber < currentBookingNumber){            
            return `The booking ${currentBookingNumber} is invalid.`;
        }
        if(!new Hotel('Bansko Grand Hotel').servicesPricing().hasOwnProperty(serviceType)){
            return `We do not offer ${serviceType} service.`;
        }
        this.services.push(serviceType);        
        for(let obj of this.bookings){
            if(obj.currentBookingNumber === currentBookingNumber){
                return `Mr./Mrs. ${obj.clientName}, Your order for ${serviceType} service has been successful.`;
            }
        }        
    }
    checkOut(currentBookingNumber){
        let totalMoney = 0;
        for(let obj of this.bookings){                     
            if(obj.currentBookingNumber === currentBookingNumber){
                totalMoney = new Hotel().roomsPricing()[obj.roomType] * obj.nights;
                if(obj.roomType == 'single'){
                    this.singleRoomsCount++;
                }else if(obj.roomType == 'double'){
                    this.maisonetteCount++;
                }else if(obj.roomType == 'maisonette'){
                    this.maisonetteCount++;
                }
                let totalServiceMoney = 0;
                if(this.services.length > 0){                    
                    for(let service of this.services){                        
                        totalServiceMoney += new Hotel('Grand Palace').servicesPricing()[service];
                    }
                    totalMoney += totalServiceMoney;
                }else{
                    return `We hope you enjoyed your time here, Mr./Mrs. ${obj.clientName}. The total amount of money you have to pay is ${totalMoney} BGN.`;
                }
                return `We hope you enjoyed your time here, Mr./Mrs. ${obj.clientName}. The total amount of money you have to pay is ${totalMoney} BGN. You have used additional room services, costing ${totalServiceMoney} BGN.`;
            }
        }
    }
    report(){
        if(this.bookings.length > 0){
            let output = `${this.name.toUpperCase()} DATABASE:\n${'-'.repeat(20)}`;
            for(let i = 0 ; i < this.bookings.length; i++){
                let booking = this.bookings[i];
            //for(let booking of this.bookings){
                output += `\nbookingNumber - ${booking.currentBookingNumber}`;
                output += `\nclientName - ${booking.clientName}`;
                output += `\nroomType - ${booking.roomType}`;
                output += `\nnights - ${booking.nights}`;                             
                if(this.services[booking.currentBookingNumber]){
                    output += `\nservices: ${this.services.join(', ')}`;    
                }
                if(i < this.bookings.length - 1){
                    output += `\n${'-'.repeat(10)}`;
                }
            }
            return output;            
        }
        return `${this.name.toUpperCase()} DATABASE:
        ${'-'.repeat(20)}
       There are currently no bookings.`;
    }
}
let hotel = new Hotel('HotUni', 10);

hotel.rentARoom('Peter', 'single', 4);
hotel.rentARoom('Robert', 'double', 4);
hotel.rentARoom('Geroge', 'maisonette', 6);

hotel.roomService(3, 'housekeeping');
hotel.roomService(3, 'drink');
hotel.roomService(2, 'room');

console.log(hotel.report());