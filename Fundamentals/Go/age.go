package kata

import "math"

func TwiceAsOld(dadYearsOld int, sonYearsOld int) int {
	return int(math.Abs(float64(dadYearsOld - (sonYearsOld * 2))))
}
