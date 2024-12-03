//7 kyu Factorial
/*function factorial(n) {
    if (n < 0 || n > 12) {
      throw new RangeError;
    }
  
    let result = 1;
    for (let i = 1; i <= n; i++) {
      result *= i;
    }
    return result;
  }
//7 kyu The Baum-Sweet sequence
function* baumSweet() {
  let n = 0;
  while (true) {
    if (n === 0) {
      yield 1; 
    } else {
      const binary = n.toString(2);
      const blocks = binary.split('1'); 
      const hasOddZeroBlock = blocks.some(block => block.length % 2 !== 0);

      yield hasOddZeroBlock ? 0 : 1;
    }
    n++;
  }
}
//7 kyu Minimum Steps (Array Series #6)
function minimumSteps(numbers, value) {
  numbers.sort((a, b) => a - b);

  let sum = 0;
  let steps = 0;

  for (let i = 0; i < numbers.length; i++) {
    sum += numbers[i];
    if (sum >= value) {
      return steps; 
    }
    steps++; 
  }

  return steps;
}
//7 kyu Reverse words
function reverseWords(str) {
  return str.split(' ').map(word => word.split('').reverse().join('')).join(' ');  
}
//7 kyu How many days are we represented in a foreign country?
function daysRepresented(trips) {
  let daysSet = new Set();

  for (let [start, end] of trips) {
    for (let day = start; day <= end; day++) {
      daysSet.add(day);
    }
  }

  return daysSet.size;
}
//7 kyu Can Santa save Christmas?
function determineTime(durations) {
  let totalSeconds = 0;

  for (let duration of durations) {
    let [hours, minutes, seconds] = duration.split(':').map(Number);

    totalSeconds += (hours * 3600) + (minutes * 60) + seconds;
  }

  return totalSeconds <= 86400;
}
//7 kyu Simple Fun #176: Reverse Letter
function reverseLetter(str) {
  const filteredStr = str.replace(/[^a-z]/g, '');

  const reversedStr = filteredStr.split('').reverse().join('');

  return reversedStr;
}
//7 kyu Remove anchor from URL
function removeUrlAnchor(url){
  return url.split('#')[0];
}
//7 kyu Maximum Length Difference
function mxdiflg(a1, a2) {
  if (a1.length === 0 || a2.length === 0) {
    return -1;
  }

  const a1Min = Math.min(...a1.map(str => str.length));
  const a1Max = Math.max(...a1.map(str => str.length));
  const a2Min = Math.min(...a2.map(str => str.length));
  const a2Max = Math.max(...a2.map(str => str.length));

  return Math.max(Math.abs(a1Max - a2Min),Math.abs(a2Max - a1Min)
  );
}
//7 kyu Two Oldest Ages
// return the two oldest/oldest ages within the array of ages passed in.
function twoOldestAges(ages) {
  const sortedAges = ages.sort((a, b) => a - b);
  
  const secondOldest = sortedAges[sortedAges.length - 2];
  const oldest = sortedAges[sortedAges.length - 1];
  
  return [secondOldest, oldest];
}*/
//7 kyuThinkful - Number Drills: Rømer temperature
function celsiusToRomer(temp) {
  return (21 / 40) * temp + 7.5;
}

//Библиотека chai
const { assert } = require('chai');

describe("Celsius to Romer", function () {
  it("Basic testing", function () {
    assert.approximately(celsiusToRomer(24), 20.1, 0.000000001, 'celsiusToRomer(24)');
    assert.approximately(celsiusToRomer(8), 11.7, 0.000000001, 'celsiusToRomer(8)');
    assert.approximately(celsiusToRomer(29), 22.725, 0.000000001, 'celsiusToRomer(29)');
  });
});
//7 kyu Number of People in the Bus
var number = function(busStops) {
  let totalPeople = 0; 

  for (let [on, off] of busStops) {
    totalPeople += on; 
    totalPeople -= off; 
  }

  return totalPeople; 
};

