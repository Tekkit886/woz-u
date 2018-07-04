class Employee {
    constructor(name, salary, hireDate, jobDescription, yearsExperience, degreeCompleted) {
        this.name = name;
        this.salary = salary;
        this.hireDate = hireDate;
        this.jobDescription = jobDescription;
        this.yearsExperience = yearsExperience;
        this.degreeCompleted = degreeCompleted;     
    }
        getName() {
            console.log(this.name.toUpperCase());
        }
        getSalary() {
            console.log(this.salary);
        }
        getHireDate() {
            console.log(this.hireDate);
        }
        getJobDescription() {
            console.log(this.jobDescription);
        }
        getYearsExperience() {
            console.log(this.yearsExperience);
        }
        getDegreeCompleted() {
                console.log(this.degreeCompleted);
        }
    }


class Manager extends Employee() {};
class Designer extends Employee() {};
class Manager extends Employee() {};
