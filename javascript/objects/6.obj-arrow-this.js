let outer_value = 0;
const obj = {
    makeWeb() {
        this.outer_value = 5;
    }
}
console.log(obj.outer_value)


// all I know for now is, never use this inside an arrow function
outer_value2 = 0
const obj2 = {
    makeWeb: () => {
        this.outer_value2 = 5;
    }
}
console.log(obj.outer_value2)