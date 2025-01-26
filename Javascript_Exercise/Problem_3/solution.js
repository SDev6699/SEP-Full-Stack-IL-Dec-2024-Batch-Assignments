function checkEmailId(str) {
    // convert to lowercase to make the check case-insensitive
    let lowerStr = str.toLowerCase();

    let atIndex = lowerStr.indexOf('@');
    let dotIndex = lowerStr.indexOf('.', atIndex + 1);

    // Conditions to check:
    // 1) '@' found and '.' found
    // 2) '@' < '.'
    // 3) at least 1 character between '@' and '.'

    if (atIndex === -1 || dotIndex === -1) {
        return false;
    }

    if (dotIndex < atIndex) {
        return false;
    }

    // Check if there's at least one character between '@' and '.'
    if (dotIndex - atIndex < 2) {
        return false;
    }

    return true;
}

// Testing:
console.log(checkEmailId("test@example.com"));  // true
console.log(checkEmailId("test@.com"));         // false (@ and . have no chars in between)
console.log(checkEmailId("example.com"));       // false (missing @)
console.log(checkEmailId("test@Example.Com"));  // true (case-insensitive check)
