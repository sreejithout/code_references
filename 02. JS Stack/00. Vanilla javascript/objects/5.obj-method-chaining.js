const obj = {
    web: 0,
    makeWeb() {
        this.web += 1;
        return this; // this line makes the chaining possible 
    },
    makeVala() {
        this.web += 1;
    }
}

obj.makeWeb().makeWeb();
console.log(obj.web)

obj.makeVala().makeVala(); // this will break