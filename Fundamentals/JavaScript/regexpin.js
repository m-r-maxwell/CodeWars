function validatePIN (pin) {
    res = /^\d{4}$|^\d{6}$/g.test(pin);
    return res
  }