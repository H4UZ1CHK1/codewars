//6_2
function expandedForm(num) {
    let [integerPart, fractionalPart] = String(num).split('.');
  
    let result = [];
  
    for (let i = 0; i < integerPart.length; i++) {
      let digit = integerPart[i];
      if (digit !== '0') {
        result.push(digit + '0'.repeat(integerPart.length - i - 1));
      }
    }
  
    if (fractionalPart) {
      for (let i = 0; i < fractionalPart.length; i++) {
        let digit = fractionalPart[i];
        if (digit !== '0') {
          result.push(digit + '/' + Math.pow(10, i + 1));
        }
      }
    }
  
    return result.join(' + ');
  }
//6_3
function digitalRoot(n) {

    while (n >= 10) {
      n = n.toString().split('').reduce((sum, digit) => sum + Number(digit), 0);
    }
  
    return n;
  }
//5_1
function isSolved(board) {

    function checkWinner(player) {
      for (let i = 0; i < 3; i++) {
        if (board[i][0] === player && board[i][1] === player && board[i][2] === player) return true; 
        if (board[0][i] === player && board[1][i] === player && board[2][i] === player) return true; 
      }
      if (board[0][0] === player && board[1][1] === player && board[2][2] === player) return true; 
      if (board[0][2] === player && board[1][1] === player && board[2][0] === player) return true; 
      
      return false;
    }
  
    if (checkWinner(1)) return 1;
  
    if (checkWinner(2)) return 2;
  
    for (let row of board) {
      if (row.includes(0)) return -1;
    }
  
    return 0;
  }  
//5_2
var CaesarCipher = function (shift) {
    this.shift = shift;
  
    this.shiftChar = function (char, shift) {
      const charCode = char.charCodeAt(0);
  
      if (charCode >= 65 && charCode <= 90) { 
        return String.fromCharCode(((charCode - 65 + shift) % 26) + 65);
      }
      if (charCode >= 97 && charCode <= 122) { 
        return String.fromCharCode(((charCode - 97 + shift) % 26) + 65);
      }
      return char;
    };
  
    this.encode = function (str) {
      return str.split('').map(char => this.shiftChar(char, this.shift)).join('');
    };
  
    this.decode = function (str) {
      return str.split('').map(char => this.shiftChar(char, 26 - this.shift)).join('');
    };
  };  
//5_3
var GeneticAlgorithm = function () {};

GeneticAlgorithm.prototype.generate = function (length) {
  let chromosome = '';
  for (let i = 0; i < length; i++) {
    chromosome += Math.round(Math.random()); 
  }
  return chromosome;
};

GeneticAlgorithm.prototype.select = function (population, fitnesses) {
  let sum = fitnesses.reduce((a, b) => a + b, 0);
  let pick = Math.random() * sum;
  let current = 0;
  
  for (let i = 0; i < population.length; i++) {
    current += fitnesses[i];
    if (current > pick) {
      return population[i];
    }
  }
};

GeneticAlgorithm.prototype.mutate = function (chromosome, p) {
  let mutated = '';
  for (let i = 0; i < chromosome.length; i++) {
    if (Math.random() < p) {
      mutated += chromosome[i] === '0' ? '1' : '0'; 
    } else {
      mutated += chromosome[i]; 
    }
  }
  return mutated;
};

GeneticAlgorithm.prototype.crossover = function (chromosome1, chromosome2) {
  if (Math.random() < 0.6) {
    let crossoverPoint = Math.floor(Math.random() * chromosome1.length);
    let offspring1 = chromosome1.slice(0, crossoverPoint) + chromosome2.slice(crossoverPoint);
    let offspring2 = chromosome2.slice(0, crossoverPoint) + chromosome1.slice(crossoverPoint);
    return [offspring1, offspring2];
  }
  return [chromosome1, chromosome2]; 
};

GeneticAlgorithm.prototype.run = function (fitness, length, p_c, p_m, iterations = 100) {
  let populationSize = 100;
  let population = [];
  
  for (let i = 0; i < populationSize; i++) {
    population.push(this.generate(length));
  }

  for (let iter = 0; iter < iterations; iter++) {

    let fitnesses = population.map(fitness);

    let newPopulation = [];

    while (newPopulation.length < populationSize) {
      let parent1 = this.select(population, fitnesses);
      let parent2 = this.select(population, fitnesses);

      let [offspring1, offspring2] = this.crossover(parent1, parent2);
      offspring1 = this.mutate(offspring1, p_m);
      offspring2 = this.mutate(offspring2, p_m);

      newPopulation.push(offspring1, offspring2);
    }

    population = newPopulation.slice(0, populationSize);
  }

  let bestFitness = -Infinity;
  let bestChromosome = null;
  for (let i = 0; i < population.length; i++) {
    let currentFitness = fitness(population[i]);
    if (currentFitness > bestFitness) {
      bestFitness = currentFitness;
      bestChromosome = population[i];
    }
  }
  return bestChromosome;
};

function fitness(chromosome) {
  let target = "11110000111100001111000011110000111"; 
  let fitnessValue = 0;
  for (let i = 0; i < chromosome.length; i++) {
    if (chromosome[i] === target[i]) {
      fitnessValue++; 
    }
  }
  return fitnessValue;
}

let ga = new GeneticAlgorithm();

let chromosomeLength = 35; 
let crossoverProbability = 0.6;
let mutationProbability = 0.002; 
let iterations = 100;

let bestSolution = ga.run(fitness, chromosomeLength, crossoverProbability, mutationProbability, iterations);
//4_1
snail = function(array) {
    let result = [];
    while (array.length) {
  
      result = result.concat(array.shift());
      
      for (let i = 0; i < array.length; i++) {
        result.push(array[i].pop());
      }
      
      if (array.length) {
        result = result.concat(array.pop().reverse());
      }
      
      for (let i = array.length - 1; i >= 0; i--) {
        result.push(array[i].shift());
      }
    }
    
    return result;
  };
//4_2
function formatDuration(seconds) {
    if (seconds === 0) return "now"; 
  
    const timeUnits = [
      { unit: "year", value: 365 * 24 * 3600 },
      { unit: "day", value: 24 * 3600 },
      { unit: "hour", value: 3600 },
      { unit: "minute", value: 60 },
      { unit: "second", value: 1 }
    ];
  
    let result = [];
  
    for (let { unit, value } of timeUnits) {
      const amount = Math.floor(seconds / value); 
      if (amount > 0) {
        result.push(amount + " " + unit + (amount > 1 ? "s" : "")); 
        seconds -= amount * value; 
      }
    }
  
    return result.length > 1
      ? result.slice(0, -1).join(", ") + " and " + result[result.length - 1]
      : result[0];
  }  
//4_3
function sumIntervals(intervals) {

    intervals.sort((a, b) => a[0] - b[0]);
  
    let totalLength = 0;
    let currentStart = null;
    let currentEnd = null;
  
    for (const [start, end] of intervals) {
      if (currentEnd === null || start > currentEnd) {
        if (currentEnd !== null) {
          totalLength += currentEnd - currentStart;
        }
  
        currentStart = start;
        currentEnd = end;
      } else {
        currentEnd = Math.max(currentEnd, end);
      }
    }
  
    if (currentEnd !== null) {
      totalLength += currentEnd - currentStart;
    }
  
    return totalLength;
  }
  