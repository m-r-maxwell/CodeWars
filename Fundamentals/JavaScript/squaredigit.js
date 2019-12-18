squareDigits = (num) => {
      let numstring = num.toString();
      let arr = [];
      for (var i = 0; i < numstring.length; i++){
          arr[i] = numstring[i] * numstring[i];
      }
      return Number(arr.join(''));
  }