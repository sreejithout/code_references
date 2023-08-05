// declaration OR definition OR statement

// declaration Works with the hoisting like this
const loaves = makeBread(7); // 7 in arguments
loaves

function makeBread(qty) { // qty is parameter
    return qty;    
}