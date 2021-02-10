class Employee {

    name : string;
    id : number;
    address : string;
    constructor(empName: string, empId: number,empAddress: string) {
        this.name = empName;
        this.id = empId;
        this.address = empAddress;
    }
    Show=()=>{
        console.log('Employee details are:\nEmployee number: ' + this.id + '\nEmployee name: ' + this.name + '\nEmployee Address: ' + this.address);
    }
}
let obj1: Employee = new Employee('Nikhil',123,"Hyderabad"); 
obj1.Show();