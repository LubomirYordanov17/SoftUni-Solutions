const companyAdministration = {

    hiringEmployee(name, position, yearsExperience) {
        if (position == "Programmer") {
            if (yearsExperience >= 3) {
                return `${name} was successfully hired for the position ${position}.`;
            } else {
                return `${name} is not approved for this position.`;
            }
        }
        throw new Error(`We are not looking for workers for this position.`);
    },
    calculateSalary(hours) {

        let payPerHour = 15;
        let totalAmount = payPerHour * hours;

        if (typeof hours !== "number" || hours < 0) {
            throw new Error("Invalid hours");
        } else if (hours > 160) {
            totalAmount += 1000;
        }
        return totalAmount;
    },
    firedEmployee(employees, index) {

        let result = [];

        if (!Array.isArray(employees) || !Number.isInteger(index) || index < 0 || index >= employees.length) {
            throw new Error("Invalid input");
        }
        for (let i = 0; i < employees.length; i++) {
            if (i !== index) {
                result.push(employees[i]);
            }
        }
        return result.join(", ");
    }}
module.exports = {companyAdministration};

let {expect} = require('chai');

let {assert} = require('chai');
const { hiringEmployee } = require('./companyAdministration');
    describe("Tests companyAdministration", function() {
        describe("Tests hiringEmployee", function() {
    
            it("Expect programe to work 1", function() {
                assert.throw(()=>companyAdministration.hiringEmployee("Ivan","prog",6)),`We are not looking for workers for this position.`
            });
            it("Expect programe to work if years are more than 3", function() {
                expect(hiringEmployee("Ivan","Programmer",6)).to.equal(`Ivan was successfully hired for the position Programmer.`)
            });
            it("Expect programe not to work if years are more than 3", function() {
                expect(hiringEmployee("Ivan","Programmer",2)).to.equal(`Ivan is not approved for this position.`)
            });


         });
         describe("Tests calculateSalary", function() {
    
            it("Expect to throw if there is wrong number", function() {
                assert.throw(()=>companyAdministration.calculateSalary("ehooo")),"Invalid hours"
                assert.throw(()=>companyAdministration.calculateSalary(-10)),"Invalid hours"
            });
            it("Expect programe to work if years are more than 3", function() {
                expect(companyAdministration.calculateSalary(161)).to.equal(3415)
            });
            it("Expect programe not to work if years are more than 3", function() {
                expect(companyAdministration.calculateSalary(160)).to.equal(2400)
            });
            

         });
         describe("Tests firedEmployee", function() {
            it("Expect to throw if there is wrong number", function() {
                assert.throw(()=>companyAdministration.firedEmployee("ehooo",2)),"Invalid input"
                assert.throw(()=>companyAdministration.firedEmployee([],1)),"Invalid input"
                assert.throw(()=>companyAdministration.firedEmployee({},1)),"Invalid input"
                assert.throw(()=>companyAdministration.firedEmployee(["Ivan","Kiril"],-1)),"Invalid input"
                assert.throw(()=>companyAdministration.firedEmployee(["Ivan","Kiril"],4)),"Invalid input"
            });
            it("Expect programe to work if years are more than 3", function() {
                expect(companyAdministration.firedEmployee(["Ivan","Kiril","Gosho"],2)).to.equal("Ivan, Kiril")
            });
            


        });
        
    });