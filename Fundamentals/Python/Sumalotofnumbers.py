def f(n):
    if n == 0:
        return None
        
    elif(isinstance(n, int)):
        sum = 0
        if int(n) >= 1 and int(n) % 1 == 0:
            for n in range(0, n+1):
                sum += n
            return sum
        else:
            return None
"""
one liner
return n * (n + 1) // 2 if (n > 0 and isinstance(n, int)) else None
"""