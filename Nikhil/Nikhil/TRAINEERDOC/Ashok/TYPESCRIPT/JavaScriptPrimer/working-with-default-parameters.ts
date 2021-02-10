let myFunc = function(name: string, weather: string = 'cold') {
    console.log('Hi ' + name + ', Today is: ' + weather);
};

let exec1 = myFunc('Chalapathi', 'Raining');
let exec2 = myFunc('Swapna');