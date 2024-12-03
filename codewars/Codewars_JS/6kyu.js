//6 kyu Make the Deadfish Swim
function parse(data) {
    let value = 0; 
    const result = []; 
  
    for (let char of data) {
      switch (char) {
        case 'i': 
          value++;
          break;
        case 'd': 
          value--;
          break;
        case 's': 
          value *= value;
          break;
        case 'o': 
          result.push(value);
          break;
        
      }
    }
  
    return result;
  }
  