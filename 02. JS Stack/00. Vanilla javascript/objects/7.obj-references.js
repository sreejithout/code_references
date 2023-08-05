// primitive types are stored in stacks
let a = 'a'
let b = a;
console.log(a,b);
a = 'aa';
console.log(a,b);

// These are references
let c = { boo: 'boo' };
let d = c;
console.log(c,d);
d.boo = 'foo';
console.log(c,d);

// These are not references
let e = { boo: 'boo' };
let f = {...e};
console.log(e,f);
f.boo = 'foo';
console.log(e,f);