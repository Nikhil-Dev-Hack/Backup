let method1 = function(...args) {
    for(let i:number = 0; i < args.length; i++) {
        console.log(args[i]);
    }
};

let result = method1(1,2,3,4,5,6);
result = method1('One', 'two', 'three', 4, 5.6, 7);