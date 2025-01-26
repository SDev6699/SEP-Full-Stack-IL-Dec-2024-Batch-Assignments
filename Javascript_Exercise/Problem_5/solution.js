// Step 1
let styles = ["James", "Brennie"];
console.log(styles);
// ["James", "Brennie"]

// Step 2: Append "Robert"
styles.push("Robert");
console.log(styles);
// ["James", "Brennie", "Robert"]

// Step 3: Replace the middle element with "Calvin"
// The middle index for an odd-length array is Math.floor(styles.length / 2)
let middleIndex = Math.floor(styles.length / 2);
styles[middleIndex] = "Calvin";
console.log(styles);
// ["James", "Calvin", "Robert"]

// Step 4: Remove and show the first value
let removedFirst = styles.shift();
console.log(removedFirst);
// "James"
console.log(styles);
// ["Calvin", "Robert"]

// Step 5: Prepend "Rose" and "Regal"
styles.unshift("Rose", "Regal");
console.log(styles);
// ["Rose", "Regal", "Calvin", "Robert"]
