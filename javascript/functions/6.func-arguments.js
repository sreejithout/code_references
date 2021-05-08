const object = {
    cat: 'sdf'
};

const arr = [5,65];

// 1. Arguments
function argumentExample(params) {
    console.log(arguments) // 
}
argumentExample(object);
argumentExample(arr);


// 2. object destructure
function destructureExample(params) {
    const { cat, second, third } = params;
    console.log(cat)
}

destructureExample(object);

// 3. rest operator
function restExample(...params) {
    console.log(params);
} 

restExample(5,6);


