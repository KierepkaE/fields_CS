using System;

namespace Fields {
  class Person {
    private DateTime Birthdate { get; set; }

    public int Age {
      {
        get {
          var timeSpan = DateTime.Today - Birthdate;
          var years = timeSpan.Days / 365;
          return years;
        };

      }
    };

  };
}