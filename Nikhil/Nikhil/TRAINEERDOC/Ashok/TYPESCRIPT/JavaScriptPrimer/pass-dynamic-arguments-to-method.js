var method1 = function () {
    var args = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        args[_i] = arguments[_i];
    }
    for (var i = 0; i < args.length; i++) {
        console.log(args[i]);
    }
};
var result = method1(1, 2, 3, 4, 5, 6);
result = method1('One', 'two', 'three', 4, 5.6, 7);
