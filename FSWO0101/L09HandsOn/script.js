
let infoBio = JSON.parse('{"name": "Albert Einstein", "URL": "https://en.wikipedia.org/wiki/File:Einstein_1921_by_F_Schmutzer_-_restoration.jpg", "birthday": "March 14, 1879"}');

let newRequest = new XMLHttpRequest();
newRequest.onreadystatechange = function() {
    if(this.readyState == 4 && this.status == 200){
        let infoBio = JSON.parse(this.responseText);
        document.getElementById("#infoBio").innerHTML = infoBio.name;
    }
};
$(document).ready(function () {
 $("#bio").click(function (event) {
     $("#stage").load("einstein.json");
 });

});