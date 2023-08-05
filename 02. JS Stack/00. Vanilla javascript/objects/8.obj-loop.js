const obj = {
    comet: 'com',
    dino: 'trex'
};

// 1. for in (use at your own risk)
for(item in obj){
    console.log(item);
}

// 2. for of keys
for(k of Object.keys(obj)) {
    console.log(k);
}

// 3. for of values
for(v of Object.values(obj)) {
    console.log(v);
}

// 4. for of entries
for([k, v] of Object.entries(obj)) {
    console.log(k, v);
}

// 5. for of entries
for(item of Object.entries(obj)) {
    console.log(item);
}