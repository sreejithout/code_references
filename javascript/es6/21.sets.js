var s = [1,1,1,1,1,2];
const exampleSet = new Set(s);

exampleSet.forEach((e) => {
    console.log(e);
});

exampleSet.add(3);
exampleSet.delete(1);
console.log(exampleSet.has(1));
exampleSet.clear();
console.log(exampleSet);