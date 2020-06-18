const multiply = require("../multiply");
const expect = require("chai").expect;

describe("Multiply", () => {
  it("should multiply properly when passed numbers", () => {
    expect(multiply(2, 4)).to.equal(8);
  });

  it("should throw when not passed numbers", () => {
    expect(() => {
      multiply("a", 2)
    }).to.throw(Error);
  });
});
