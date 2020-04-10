function diamond(n){
    if (n < 0 || !(n % 2)) return null; 
    const middleIndex = Math.floor(n / 2);
    
    return Array.apply(null, {length: n})
        .map((el, index) => {
          const indentation = Math.abs(index - middleIndex);
          const numberOfAsterisks = n - indentation * 2;
          return Array(indentation + 1).join(' ') + Array(numberOfAsterisks + 1).join('*');
        })
        .join('\n') + '\n';
  }