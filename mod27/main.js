function buna(){
    alert("This is inside the funtion")
}
buna()

function una(number1,number2){
    return  number1+number2
}
console.log(una(10,10))

function toCelsius(numri1){
    return numri1*5/9
}
console.log ("54 farinheit eshte e barabart me"+toCelsius(54)+"celsius")

function drin (){
    var localVar="I am buna";
    alert("hello i am BUNA");
}
drin();

var Jora = () => alert("hello watcher's");
Jora()

function twosecond(number1){
 return  number1*60 
}
console.log (twosecond(2))

var kerri = { name:"opel", color:"black" , year:2024, startEngine:function(){
    alert("VROOOOMMMM!!!!!!!!!!!")
}}

var shkolla = {
    name:"Dardania",
    student:1200,
    year:1989,
    subjekt:"gj.sh"
}
console.log (kerri.name)
console.log (shkolla.year)

kerri.startEngine()

var computer = new Object();
computer.name-"lenovo";
computer.CPU="Inter Core i7";
computer.GPU = "GeForce 4080";

computer.type = function(){
    return name+this.CPU+this.RAM+this.GPU;
};
 
console.log(computer.type());

console.log(computer.type)
   

