const apiUrl = "https://fcctop100.herokuapp.com/api/fccusers/top/alltime";

function getTop100CampersPromise() {
    fetch(apiUrl)
    .then((r) => r.json())
    .then((json) => {
        console.log(json[0]);
    })
    .catch((err) => {
        console.log("Failed");
    });
}

getTop100CampersPromise();



async function getTop100CampersAsync() {
    const response = await fetch(apiUrl);
    const json = await response.json();
    console.log(json[0]);
}


function resolveAfter3Seconds() {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve('resolved');
        }, 3000);
    });
}

resolveAfter3Seconds().then((data) => {
    console.log(data);
}).catch((err) => {
    console.log(err);
});