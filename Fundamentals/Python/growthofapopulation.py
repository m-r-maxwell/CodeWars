def nb_year(p0, percent, aug, p, count = 0):
    if (p0 >= p):
        return count
    else:
        count += 1
        pop = p0 + p0 * (percent/100) + aug
        return nb_year(pop, percent, aug, p, count)