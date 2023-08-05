export class Animal {

    get metaData() {
        return ` Type ${this.type}, Legs: ${this.legs}`;
    }

    constructor(type, legs) {
        this.type = type;
        this.legs = legs;
    }

    makeNoise(sound = 'Loud Noise') {
        console.log(sound);
    }

    static return10() {
        return 10;
    }
}