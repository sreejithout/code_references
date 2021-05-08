var date = new Date('2021-04-01');
var dd = date.getUTCDate();
var mm = date.getUTCMonth() + 1;
var yyyy = date.getUTCFullYear();
if (dd < 10) {
    dd = "0" + dd;
}
if (mm < 10) {
    mm = "0" + mm;
}
console.log(mm + "/" + dd + "/" + yyyy)