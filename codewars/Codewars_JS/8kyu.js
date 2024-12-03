//8 kyu Lario and Muigi Pipe Problem
function pipeFix(numbers) {
    const min = numbers[0]; 
    const max = numbers[numbers.length - 1]; 

    const fixedPipes = [];
    for (let i = min; i <= max; i++) {
        fixedPipes.push(i);
    }

    return fixedPipes;
}
//8 kyu Super Duper Easy
function problem(x) {
    if (typeof x === 'string') {
      return "Error";
    }
    return x * 50 + 6;
  }
//8 kyu Find numbers which are divisible by given number
function divisibleBy(numbers, divisor) {
    return numbers.filter(num => num % divisor === 0);
  }
//8 kyuThe Wide-Mouthed frog!
function mouthSize(animal) {
  if (animal.toLowerCase() === "alligator") {
    return "small";
  } else {
    return "wide";
  }
}
//8 kyu Exclamation marks series #11: Replace all vowel to exclamation mark in the sentence
function replace(s) {
  return s.replace(/[aeiouAEIOU]/g, '!');
}
//8 kyu Short Long Short
function solution(a, b) {
  let shortStr = a.length < b.length ? a : b;
  let longStr = a.length >= b.length ? a : b;

  return shortStr + longStr + shortStr;
}
//8 kyu L1: Bartender, drinks!
function getDrinkByProfession(param) {
  const normalizedParam = param.toLowerCase();

  const drinks = {
      "jabroni": "Patron Tequila",
      "school counselor": "Anything with Alcohol",
      "programmer": "Hipster Craft Beer",
      "bike gang member": "Moonshine",
      "politician": "Your tax dollars",
      "rapper": "Cristal"
  };

  return drinks[normalizedParam] || "Beer";
}
//8 kyu Basic variable assignment
var a = "code";
var b = "wa.rs";
var name = a + b;
//8 kyu Classic Hello World
// Print "Hello World!" to the screen
class Solution {
  static main(...args) {
    console.log("Hello World!");
  }
}

