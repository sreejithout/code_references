// expression does not Work with the hoisting like this
//const loaves = makeBread(7); // 7 in arguments

const makeBread = function(qty) { // qty is parameter
    return qty;    
}

const loaves = makeBread(7);
loaves