function* name(i) {
    yield i;
    yield i + 10;
}

var gen = name(10);
console.log(gen.next().value);
console.log(gen.next().value);
