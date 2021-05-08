const spider = 'spider';
const legs = 8;

// object listeral
const obj = {
    spider,
    legs,
    legs: 10,
    legs: 23
};

// destructure object
const { spider: spidey, legs: legy } = obj;
spidey
legs

console.log(obj.legs)
