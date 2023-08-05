import { Animal } from "./helpers/animal.mjs";
import { Cat } from "./helpers/cat.mjs";

let dog = new Animal('dog', 4);

console.log(dog);
console.log(dog.makeNoise('bow'));
console.log(Animal.return10());
console.log(dog.metaData);
