function prefill(n, v) {
    if (isNaN(parseInt(n)) || n % 1 !== 0 || n < 0) {
      throw new TypeError(`${n} is invalid`);
    }
    return Array.from({ length: n }).fill(v);
  };