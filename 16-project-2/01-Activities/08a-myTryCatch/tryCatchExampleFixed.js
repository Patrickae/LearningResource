const fs = require("fs");

try {
  const contents = fs.readFileSync("test.txt", "utf8");
  console.log(contents);
} catch (err) {
  console.log(`uh oh... ${err}`);
}

console.log("I'm done!");
