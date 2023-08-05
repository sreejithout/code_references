const organism = {
    dna: Math.random
};

const obj = Object.create(organism);

console.log(obj);
console.log(Object.getPrototypeOf(obj));
console.log(obj.dna);

Object.defineProperty(obj, 'whoami', {
    ready: 'yes'
});
console.log(obj);
console.log(Object.getPrototypeOf(obj));
console.log(obj.whoami);