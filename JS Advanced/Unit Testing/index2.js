const { use } = require("chai");

class SmartHike{
    constructor(username){
this.username=username
this.goals={}
this.listOfHikes=[]
this.resources=100
    }
    addGoal (peak, altitude){
        
if (!this.goals.peak) {
    this.goals=Object.assign(peak,altitude);
return `You have successfully added a new goal - ${peak}`
    
}
throw new Error(`${peak} has already been added to your goals`)
    }

}
const user = new SmartHike('Vili');
console.log(user.addGoal('Musala', 2925));
console.log(user.addGoal('Rui', 1706));
console.log(user.addGoal('Musala', 2925));
