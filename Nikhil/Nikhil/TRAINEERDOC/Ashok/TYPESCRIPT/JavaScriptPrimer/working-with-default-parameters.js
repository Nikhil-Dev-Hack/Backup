var myFunc = function (name, weather) {
    if (weather === void 0) { weather = 'cold'; }
    console.log('Hi ' + name + ', Today is: ' + weather);
};
var exec1 = myFunc('Chalapathi', 'Raining');
var exec2 = myFunc('Swapna');
