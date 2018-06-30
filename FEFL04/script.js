// Define the class
class aClass {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }
    // Method assigned to class
    sayName() {
        alert(this.name);
    }
    // Method assigned to class
    sayAge() {
        alert(this.age);
    }
}
// Instantiating the aClass with the 'new' keyword
const myInstance = new aClass("andrew", 30);
myInstance.sayName();