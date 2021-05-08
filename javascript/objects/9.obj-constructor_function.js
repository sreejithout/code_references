// by convention, constructor functions name is capitalized
// the class keyword in modern javascript is just the syntactic sugar 
function Zombie(name) {
    this.name = name;
    this.eatBrain = function() {
        return `${this.name} is hungry for brain`;
    }
}

const obj = new Zombie('sreejith');

console.log(obj.eatBrain())