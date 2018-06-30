let age = 15;

function allowedIntoMovie() {
    if (age < 10) {
        return "Not Permitted";
    } else if (age < 15) {
        return "Permitted with parent";
    } else if (age < 18) {
        return "Permitted with anyone over 18";
    } else if (age >= 18) {
        return "Permitted to attend alone";
    }
}
console.log(allowedIntoMovie);