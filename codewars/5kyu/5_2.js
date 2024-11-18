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