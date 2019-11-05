def get_middle(s):
    strlen = len(s)
    
    if (strlen % 2 > 0):
        return (s[strlen / 2])
    
    if(strlen % 2 == 0):
        return(s[(strlen / 2 - 1): (strlen / 2 + 1)])
    else:
        return s