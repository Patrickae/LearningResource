const multiply = require("./multiply");
const chai = require("./my-chai");

// MY TESTS
const will_return_20 = () => {
  // arrange
  const x = 4;
  const y = 5;

  // act
  // const result = multiply(x, y);
  const result = chai.assertEquals(multiply, x, y, 20);

  // assert
  console.log(`will_return_20: ${result ? "success" : "fail"}`);
};

const will_throw_an_exception = () => {
  // arrange
  const x = "a";
  const y = 2;

  // act
  const result = chai.assertThrows(multiply, x, y);

  // assert
  console.log(`will_throw_an_exception: ${result ? "success" : "fail"}`);
};

// RUN TESTS
const runTests = () => {
  will_return_20();
  will_throw_an_exception();
};

runTests();
