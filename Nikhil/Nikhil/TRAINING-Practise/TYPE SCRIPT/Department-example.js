var Department = /** @class */ (function () {
    function Department(deptNo, deptName, deptLoc) {
        var _this = this;
        this.Display = function () {
            console.log('Department details are:\nDepartment number: ' + _this.id + 'Department name: ' + _this.name + '\nDepartment location: ' + _this.location);
        };
        this.id = deptNo;
        this.name = deptName;
        this.location = deptLoc;
    }
    return Department;
}());
var obj = new Department(10, 'Accounting', 'New York');
obj.Display();
