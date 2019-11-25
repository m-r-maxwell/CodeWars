function high(string){
    words = string.split(" ");
    
    var wordsObj = {};
    for (var i = 0; i < words.length; i++) {
      var word = words[i];
      wordsObj[word] = calcScore(word);
    }
    return Object.keys(wordsObj).sort(function(a, b){
      return wordsObj[b] - wordsObj[a]
    })[0];
  }
  
  function calcScore(word) {
    const alphabet= " abcdefghijklmnopqrstuvwxyz";
    chars = word.split("");
    var score = 0;
    chars.forEach(function(char) {
      score += alphabet.indexOf(char);
    });
    return score;
  }
  