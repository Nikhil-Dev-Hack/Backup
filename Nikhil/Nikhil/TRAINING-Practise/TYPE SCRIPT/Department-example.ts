class Department
{
    id: number;
    name: string;
    location: string;

    constructor(deptNo: number, deptName: string, deptLoc: string) {
        this.id = deptNo;
        this.name = deptName;
        this.location = deptLoc;
    }

     Display=()=> {
        console.log('Department details are:\nDepartment number: ' + this.id + 'Department name: ' + this.name + '\nDepartment location: ' + this.location);
    };
}
let obj: Department = new Department(10, 'Accounting', 'New York');
obj.Display();