class footballTeam{
    constructor(clubName, country){
        this.clubName = clubName;
        this.country = country;
        this.invitedPlayers = [];
    }
 
    newAdditions(footballPlayer){
 
        for(let i = 0; i < footballPlayer.length; i++){
 
            let Name = footballPlayer[i].split('/')[0];
            let Age = footballPlayer[i].split('/')[1];
            let Value = footballPlayer[i].split('/')[2];
 
            let currentPlayer = {
                name: Name,
                age: Age,
                playerValue: Value
            };
 
            let thePlayerBefore = this.invitedPlayers.find(player => player.name === currentPlayer.name); 
 
            if(thePlayerBefore){
 
                if(currentPlayer.playerValue > thePlayerBefore.playerValue){
                    thePlayerBefore.playerValue = currentPlayer.playerValue; 
                }   
 
            }
            else {
                this.invitedPlayers.push(currentPlayer);
            }
 
 
        }          
 
        this.invitedPlayers = this.invitedPlayers.filter(player => player.name !== this.invitedPlayers.name);
 
        let output = "You successfully invite ";
 
        Array.from(this.invitedPlayers).forEach(player => output += `${player.name}, `)
 
        output = output.substring(0, output.length - 2);
 
        return output += '.'
 
    }
 
    signContract(selectedPlayer){
 
        let name = selectedPlayer.split('/')[0];
        let playerOffer = selectedPlayer.split('/')[1];
 
        let currentPlayer = this.invitedPlayers.find(player => player.name == name)
 
        if(!this.invitedPlayers.find(player => player.name === name)){
            throw new Error(`${name} is not invited to the selection list!`)
        }
 
        if(playerOffer < currentPlayer.playerValue){
            throw new Error(`"The manager's offer is not enough to sign a contract with ${name}, ${currentPlayer.playerValue - playerOffer} million more are needed to sign the contract!"`);
        }
 
        currentPlayer.playerValue = "Bought";
 
        return `Congratulations! You sign a contract with ${name} for ${playerOffer} million dollars.`
    }
 
    ageLimit(name, age){
 
        if(!this.invitedPlayers.find(player => player.name === name)){
            throw new Error(`${name} is not invited to the selection list!`)
        }
 
        let currentPlayer = this.invitedPlayers.find(player => player.name == name);
 
        if(currentPlayer.age < age){
 
            let difference = age - currentPlayer.age;
 
            if(difference < 5){
                return `${name} will sign a contract for ${difference} years with ${this.clubName} in ${this.country}!`
            }
            else if(difference > 5){
                return `${name} will sign a full 5 years contract for ${this.clubName} in ${this.country}!`;
            }
        } else
        {
            return `${name} is above age limit!`;
        }
    }
 
    transferWindowResult(){
        let buffer = "";
 
        buffer += "Players list:\n"
 
        this.invitedPlayers.sort((a,b) => (a.name).localeCompare(b.name))
        .forEach(player => buffer += `Player ${player.name}-${player.playerValue}\n`);
 
        return buffer.trimEnd();
    }
}
let fTeam = new footballTeam("Barcelona", "Spain");
console.log(fTeam.newAdditions(["Kylian Mbappé/23/160", "Lionel Messi/35/50", "Pau Torres/25/52"]));
console.log(fTeam.signContract("Kylian Mbappé/240"));
console.log(fTeam.ageLimit("Kylian Mbappé", 30));
console.log(fTeam.transferWindowResult());
