package kata

import (
	"fmt"
)

func calculateSum(numbers []int, channel chan int) {
	sum := 0
	for _, num := range numbers {
		sum += num
	}
	channel <- sum // Send the calculated sum to the channel
}

func main() {
	numbers := []int{1, 2, 3, 4, 5}
	resultChannel := make(chan int) // Create an unbuffered channel for results

	// Launch two goroutines to calculate sum of half the slice each
	go calculateSum(numbers[:len(numbers)/2], resultChannel)
	go calculateSum(numbers[len(numbers)/2:], resultChannel)

	// Receive the partial sums from both goroutines
	sum1 := <-resultChannel
	sum2 := <-resultChannel

	fmt.Println("Sum of first half:", sum1)
	fmt.Println("Sum of second half:", sum2)
	fmt.Println("Total sum:", sum1+sum2)
}

/*
Unbuffered vs. Buffered Channels

Unbuffered channels: Force synchronization between sender and receiver.
A send or receive operation will block if the other side isn't ready.
Blocking until a goroutine is ready to receive can be useful for signaling.
Receiver will block until a value is sent.

Buffered channels: Have a limited internal buffer to hold sent values.
Send operations can proceed without a receiver being available (up to the buffer limit).
Receive operations can proceed without a value being sent (if there's data in the buffer).
Non-blocking but can block under certain conditions such as when the buffer is full.

*/
