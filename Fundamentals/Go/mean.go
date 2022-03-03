package kata

func GetGrade(a, b, c int) rune {
	switch mean := (a + b + c) / 3; {
	case mean < 60:
		return 'F'
	case mean < 70:
		return 'D'
	case mean < 80:
		return 'C'
	case mean < 90:
		return 'B'
	default:
		return 'A'
	}

}
