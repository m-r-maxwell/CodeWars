package kata

func Invert(arr []int) []int {
	newArr := make([]int, len(arr))
	for i := 0; i < len(arr); i++ {
		newArr[i] = arr[i] * -1
	}
	return newArr
}
