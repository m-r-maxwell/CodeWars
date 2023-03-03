package kata

func Xor(a, b bool) bool {
	if a == true && b == false {
		return true
	}
	if a == false && b == true {
		return true
	}
	return false
}

//one liner return a != b
