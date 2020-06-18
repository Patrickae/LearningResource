module.exports = {
  assertEquals: (func, x, y, res) => {
    return func(x, y) === res;
  },

  assertThrows: (func, x, y) => {
    let threw = false;

    try {
      func(x, y);
    } catch (err) {
      threw = true;
    }

    return threw;
  }
};
