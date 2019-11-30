using System;

namespace Fields {
  class Program {
    static void Main (string[] args) {
      var customer = new Customer (1);
      customer.Orders.Add (new Order ());
      customer.Orders.Add (new Order ());
      Console.WriteLine (customer.Oders.Count);

      var person = new Person ();
      person.Birthdate = new DateTime (1999, 12, 12);
      Console.WriteLine (person.Age);

    }

  };
}