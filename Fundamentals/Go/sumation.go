package kata

func Summation(n int) int {
	total := 0

	for i := 0; i <= n; i++ {
		total += i
	}
	return total

	// onliner return n * (n + 1) / 2
}
