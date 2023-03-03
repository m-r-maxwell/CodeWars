package kata

func GetSize(w, h, d int) [2]int {
	var dims [2]int

	dims[0] = (2 * (w * h)) + (2 * (w * d)) + (2 * (h * d))
	dims[1] = w * h * d
	return dims
}
