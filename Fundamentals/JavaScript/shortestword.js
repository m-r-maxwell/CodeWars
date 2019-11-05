// One-line Solution
const findShort = s => Math.min(...s.split(' ').map(word => word.length))

// Function Export
module.exports = findShort
