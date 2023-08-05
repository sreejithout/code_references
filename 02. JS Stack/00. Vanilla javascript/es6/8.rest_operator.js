function add(...nums) {
    console.log(nums);
}

add(4,5,6,8);

function add2(a, b, c) {
    console.log(a);
    console.log(b);
    console.log(c);
}

add2(...[5,6,8]);

console.log(typeof add)