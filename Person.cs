using System;

namespace Fields {
  class Person {
    private DateTime _birthday;
    public void SetBirthdate (DateTime birthdate) {
      _birthdate = birthdate;
    };
    public DateTime GetBirthdate () {
      return _birthdate;
    };
  };
}