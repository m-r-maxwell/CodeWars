package kata

import "fmt"

func palMain() {
	s := "babbad"
	fmt.Println(longestPalindrome(s)) // Output: "bab" or "aba"

	s = "cbbd"
	fmt.Println(longestPalindrome(s)) // Output: "bb"
}

// longestPalindrome finds the longest palindrome substring in a given string.
// It uses the expandAroundCenter helper function to check for palindromes
// by expanding around each character in the string.
// The function returns the longest palindrome substring found.
func longestPalindrome(s string) string {
	start, maxLen, l := 0, 0, len(s)
	for i := 0; i < l; i++ {
		// For each character in the string, we call expandAroundCenter twice:
		// once for odd length palindromic substrings (by passing the same index for `l` and `r`),
		// and once for even length palindromic substrings (by passing consecutive indices for `l` and `r`).
		// This ensures that all possible palindromic substrings are checked,
		// regardless of whether the length of the string is odd or even.
		expandAroundCenter(s, i, i, &start, &maxLen)
		expandAroundCenter(s, i, i+1, &start, &maxLen)
	}
	// Return the longest palindrome substring found.
	return s[start : start+maxLen]
}

// expandAroundCenter is a helper function that checks for palindromic substrings
// by expanding around the center (which can be a character for odd length palindromes,
// or the space between two characters for even length palindromes).
// It updates the start index and length of the longest palindrome found so far.
func expandAroundCenter(s string, l, r int, start, maxLen *int) {
	// Expand around the center as long as the characters are equal.
	for l >= 0 && r < len(s) && s[l] == s[r] {
		l, r = l-1, r+1
	}
	// If the length of the palindrome found is greater than the current maximum length,
	// update the start index and maximum length.
	if r-l-1 > *maxLen {
		*maxLen = r - l - 1
		*start = l + 1
	}
}
