package kata

import "math"

func MxDifLg(a1 []string, a2 []string) int {
	if len(a1) == 0 && len(a2) == 0 {
		return -1
	}
	maxDiff := -1

	for _, word := range a1 {
		for _, word1 := range a2 {
			dif := math.Abs(float64(len(word) - len(word1)))
			if dif > float64(maxDiff) {
				maxDiff = int(dif)
			}
		}
	}

	return maxDiff
}
