var Department = /** @class */ (function () {
    function Department(deptNo, deptName, deptLoc) {
        this.id = deptNo;
        this.name = deptName;
        this.location = deptLoc;
    }
    Department.prototype.Display = function () {
        console.log('Department details are:\nDepartment number: ' + this.id +
            'Department name: ' + this.name + '\nDepartment location: ' + this.location);
    };
    return Department;
}());
var obj = new Department(10, 'Accounting', 'New York');
obj.Display();
