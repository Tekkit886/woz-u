let idealCar = {
    type: "mustang",
    color: "red",
    weightInPounds: 3600,
    myCar: function () {
        console.log('My ideal car is a ' + idealCar.type + 'with a color of ' 
        + idealCar.color + ", but I don't want it to be over " + idealCar.weightInPounds + ' pounds.');
    }

};
idealCar.myCar();


class Vehicle {
    constructor(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
}

let myCar = new Vehicle("Nissan", "Rogue", 2017);

class Person {
    constructor(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    run() {
        console.log(this.firstName + " " + this.lastName + " is running.");
    }
    walk() {
        console.log(this.firstName + " " + this.lastName + " is walking.");
    }
    greeting() {
        console.log("Hello, my name is " + this.firstName + ".");
    }
}

let rose = new Person("Rose", "Dawson");
rose.run();
rose.walk();
rose.greeting();

class Car {
    constructor(make, model, year) {
        this._make = make;
        this._model = model;
        this._year = year;
    }

    get make() {
        return this._make;
    }

    set make(value) {
        const possibleMakes = ["Honda", "Toyota", "Nissan"];

        if (possibleMakes.includes(value)) {
            this._make = value;
        } else {
            throw Error(value + " is not a valid make");
        }
    }

    get description() {
        return this._year + " " + this._make + " " + this._model;
    }
}

let myCar = new Car("Nissan", "Rogue", 2017);

class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    greeting() {
        console.log(
            "Hello, my name is " + this.name + " and I am " + this.age + "."
        );
    }
}

let andrew = new Person("Andrew", 30);
let mike = new Person("Mike", 24);
let frank = new Person("Frank", 29);
andrew.greeting();
mike.greeting();
frank.greeting();