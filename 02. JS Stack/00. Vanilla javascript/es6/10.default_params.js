function add(numArray = [5,6]) {
    let total = 0;
    numArray.forEach((e) => total += e);
    console.log(total);
}

add();