// 1. literal syntax
const obj = {
    year: 1987 // property
};
obj.name = "sreejith"; // property


// 2. using constructor
const obj1 = new Object();
obj1["my name"] = "sreejith r k";



let list = [
    {
        name: "sreejith",
        id: 1
    },
    {
        name: "jith",
        id: 2
    }
]

list = list.filter(x => x.id == 3);
console.log(list);