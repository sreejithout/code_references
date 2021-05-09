// 1. literal syntax
const obj = {
    year: 1987 // property
};
obj.name = "john"; // property


// 2. using constructor
const obj1 = new Object();
obj1["my name"] = "john doe";



let list = [
    {
        name: "john",
        id: 1
    },
    {
        name: "jith",
        id: 2
    }
]

list = list.filter(x => x.id == 3);
console.log(list);