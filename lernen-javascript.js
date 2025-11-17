function checkUsername(username) {
    if(typeof username =="string" && username.length >= 3) {
       return "username is valid"
    }
    else {
        return "username is unvaild"
    }
}

const person = {name: "Mario", age: 19, isSchueler: true}; 


let bicycle = {model: "bmc", price: 9.981, isNew: true}

const value = Object.values(bicycle)
const keys = Object.keys(bicycle)


bicycle.model = "bmw";
console.log(bicycle)

bicycle.model
bicycle["model"]

let i = ["model"]
bicycle[i] = "canondale";
















