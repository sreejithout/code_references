const ghost = {
    face: 'ghost'
}

const clown = {
    face: 'clown'
}

function hello() {
    return this.face;
}

console.log(hello.call(ghost));
console.log(hello.call(clown));