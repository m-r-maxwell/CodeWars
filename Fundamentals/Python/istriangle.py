def is_triangle(a, b, c):
    maxnum = max(a, b, c)
    sum = a + b + c
    return sum - maxnum > maxnum
