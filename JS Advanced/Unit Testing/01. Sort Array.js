function solve(array,word){
return word=='asc'?array.sort((a,b)=>a-b):array.sort((a,b)=>b-a)
}
console.log(solve([14, 7, 17, 6, 8], 'asc'))