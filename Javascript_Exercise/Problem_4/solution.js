function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.slice(0, maxlength - 3) + '...';
    }
    return str;
}

// Testing:
console.log(truncate("What I'd like to tell on this topic is:", 20));
// "What I'd like to te..."

console.log(truncate("Hi everyone!", 20));
// "Hi everyone!"
