// A function that return a function


function outer() {
    const fish = 'fish';
    let count = 0;
    function inner() {
        count++;
        return `${count} ${fish}`
    }
    return inner;
}

const ft = outer();
console.log(ft())
console.log(ft())
console.log(ft())