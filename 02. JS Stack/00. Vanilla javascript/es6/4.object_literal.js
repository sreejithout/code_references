function addressMaker(city, state) {
    const newAddress = {city, state}; // with object literals, we don't have to define key value pair if the naming is same.
    console.log(newAddress);
}

addressMaker('Palakkad', 'Kerala');