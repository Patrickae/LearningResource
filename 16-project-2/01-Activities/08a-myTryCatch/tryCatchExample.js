const fs = require("fs");

const contents = fs.readFileSync("test.txt", "utf8");
console.log(contents);

console.log("I'm done!");
