interface Person {
    firstName: string[];
    lastName: string[];
    birthday: number;
}

interface Contact {
    phoneNumber: number;
    email?: string[];
    slack?: string[];
}

function formatNumber(phoneNumberObj: Contact) {
    this.phoneNumber.tostring();
}

class ContactCard implements Person, Contact {
        firstName: string;
        lastName: string;
        birthday: number;
        phoneNumber: number;
        
    constructor(firstName: string, lastName: string, birthday: number, phoneNumber: number;) {    

        this.firstName = firstName;
        this.lastName = lastName;
        this.birthday = birthday;
        this.phoneNumber = phoneNumber
    }
        function sendMessage() {
            return 'sending message!';
        }
        function addToFavorites(){
            return 'adding to favorites!'
        }
}

let sam = new ContactCard();