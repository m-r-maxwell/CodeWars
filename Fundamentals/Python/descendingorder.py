def Descending_Order(num):
    num_list = []
    for index in range(len(str(num))):
        num_list.append(str(num)[index])

    sorted_list = sorted(num_list, reverse=True)
    sorted_string = ''.join(sorted_list)

    return int(sorted_string)

#better solution
#return int("".join(sorted(str(num), reverse=True)))