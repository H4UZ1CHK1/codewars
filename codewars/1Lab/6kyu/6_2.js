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