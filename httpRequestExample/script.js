function loadDoc() {
    const xttp = new XMLHttpRequest();
    xttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200){
            document.getElementById("example").innerHTML = this.responseText;
        }
    };
    xttp.open("GET", "info.txt", true);
    xttp.send();
}