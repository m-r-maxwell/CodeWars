function friend(friends){
    let frndgroup = [];
    for(var i = 0; i < friends.length; i++){
      if(friends[i].length == 4){
        frndgroup.push(friends[i]);
      }
    }
    return frndgroup;
  }