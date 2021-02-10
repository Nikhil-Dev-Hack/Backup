var Employee = /** @class */ (function () {
    function Employee(empName, empId, empAddress) {
        var _this = this;
        this.Show = function () {
            console.log('Employee details are:\nEmployee number: ' + _this.id + '\nEmployee name: ' + _this.name + '\nEmployee Address: ' + _this.address);
        };
        this.name = empName;
        this.id = empId;
        this.address = empAddress;
    }
    return Employee;
}());
var obj1 = new Employee('Nikhil', 123, "Hyderabad");
obj1.Show();
