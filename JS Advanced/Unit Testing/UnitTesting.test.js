const chooseYourCar = {
    choosingType(type, color, year) {
        if (year < 1900 || year > 2022) {
            throw new Error(`Invalid Year!`);
        } else {
            if (type == "Sedan") {
                if (year >= 2010) {
                    return `This ${color} ${type} meets the requirements, that you have.`;
                } else {
                    return `This ${type} is too old for you, especially with that ${color} color.`;
                }
            }
            throw new Error(`This type of car is not what you are looking for.`);
        }
    },
   brandName(brands, brandIndex) {
        let result = [];
        if (!Array.isArray(brands) || !Number.isInteger(brandIndex) || brandIndex < 0 || brandIndex >= brands.length) {
            throw new Error("Invalid Information!");
        }
        for (let i = 0; i < brands.length; i++) {
            if (i !== brandIndex) {
                result.push(brands[i]);
            }
        }
        return result.join(", ");
    },
    carFuelConsumption(distanceInKilometers, consumptedFuelInLiters) {
       let litersPerHundredKm =((consumptedFuelInLiters / distanceInKilometers)* 100).toFixed(2);


        if (typeof distanceInKilometers !== "number" || distanceInKilometers <= 0 ||
            typeof consumptedFuelInLiters !== "number" || consumptedFuelInLiters <= 0) {
            throw new Error("Invalid Information!");
        } else if (litersPerHundredKm <= 7) {
            return `The car is efficient enough, it burns ${litersPerHundredKm} liters/100 km.`;
        } else {
            return `The car burns too much fuel - ${litersPerHundredKm} liters!`;
        }
    }
}
module.exports = {chooseYourCar};

let {expect} = require('chai');

let {assert} = require('chai');
describe("Tests chooseYourCar", function() {
    describe("Tests choosingType", function() {
        it("If year is not valid method should throw error", function() {
            assert.throw(()=>chooseYourCar.choosingType("Sedan","red",1899)),`Invalid Year!`
          
            assert.throw(()=>chooseYourCar.choosingType("Sedan","red",-1)),`Invalid Year!`
           
            assert.throw(()=>chooseYourCar.choosingType("Sedan","red",2023)),`Invalid Year!`
            assert.throw(()=>chooseYourCar.choosingType("Sedan","red",20024.9)),`Invalid Year!`
        });
        it("If type is not sedan method should throw error", function() {
            assert.throw(()=>chooseYourCar.choosingType("IVan","red",2004)),`This type of car is not what you are looking for.`
            assert.throw(()=>chooseYourCar.choosingType("Neshto","red",2000)),`This type of car is not what you are looking for.`
            assert.throw(()=>chooseYourCar.choosingType(2,"red",2000)),`This type of car is not what you are looking for.`
            assert.throw(()=>chooseYourCar.choosingType({},"red",2000)),`This type of car is not what you are looking for.`
            assert.throw(()=>chooseYourCar.choosingType([],"red",2000)),`This type of car is not what you are looking for.`
        });
        it("If year is above 2010 should work like", function() {
            expect(chooseYourCar.choosingType("Sedan","red",2010)).to.equal(`This red Sedan meets the requirements, that you have.`)
        });

        it("If year is before 2010 should work like", function() {
            expect(chooseYourCar.choosingType("Sedan","blue",2006)).to.equal(`This Sedan is too old for you, especially with that blue color.`)
        });
        
     });
     describe("Tests brandName", function() {
        it("If array is empty should throw error", function() {
            assert.throw(()=>chooseYourCar.brandName("ehooo",2)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(3,2)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName([],1)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName({},1)),"Invalid Information!"
        });
        it("If number is worng should throw error", function() {
           
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],"Neshto")),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],{})),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],[])),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],-1)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],4)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.brandName(["Audi","BMW"],1.2)),"Invalid Information!"
            
        });
        it("Expect to return the right things 1", function() {
            expect(chooseYourCar.brandName(["BMW","Toyota","Opel","Audi","Mercedes"],2)).to.equal("BMW, Toyota, Audi, Mercedes")
        });
        it("Expect to return the right things", function() {
            expect(chooseYourCar.brandName(["BMW","Toyota","Opel",],0)).to.equal("Toyota, Opel")
        });
    });
    describe("Tests carFuelConsumption", function() {
        it("If parametar 1 is not valid mehtod should throw error", function() {
            assert.throw(()=>chooseYourCar.carFuelConsumption("ne znam",25)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(-1,26)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption([],26)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption({},26)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(0,14)),"Invalid Information!"
            
        });
        it("If parametar 2 is not valid mehtod should throw erro", function() {
            assert.throw(()=>chooseYourCar.carFuelConsumption(42,"nz")),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(43,-1)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(43,0)),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(32,[])),"Invalid Information!"
            assert.throw(()=>chooseYourCar.carFuelConsumption(21,{})),"Invalid Information!"
        });
        it("Expect to return the right things 2", function() {
            expect(chooseYourCar.carFuelConsumption(50,2.3)).to.equal(`The car is efficient enough, it burns 4.60 liters/100 km.`)
            expect(chooseYourCar.carFuelConsumption(40,2.80)).to.equal(`The car is efficient enough, it burns 7.00 liters/100 km.`)
     
            expect(chooseYourCar.carFuelConsumption(2.8,40)).to.equal(`The car burns too much fuel - 1428.57 liters!`)
            expect(chooseYourCar.carFuelConsumption(2,25)).to.equal(`The car burns too much fuel - 1250.00 liters!`)
        });



    });

});
