let example1 = {
    firstName: 'john'
};

let example2 = {
    ...example1
};

let example3 = {
    ...example1,
    example2,
    third : 3
};

example2.firstName = "me"
example1
example2
example3
