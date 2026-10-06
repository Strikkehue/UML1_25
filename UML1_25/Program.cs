using UML1_25;

//Console.WriteLine("Pizzaer:");
Pizza p1 = new Pizza(1, "Marcerita", "Tomato & Cheese", 69);

//Console.WriteLine(p1.ToString());
Pizza p2 = new Pizza(1, "Vesuvio", "Tomato, Cheese & Ham", 75);
//Console.WriteLine(p2.ToString());
Pizza p3 = new Pizza(1, "Capricciosa", "Tomato, Cheese, Ham & Mushrooms", 80);
//Console.WriteLine(p3.ToString());
//Console.WriteLine("Kunder:");

Customer c1 = new Customer(1, "Peter", "Gade 123", "12121212");


//Console.WriteLine(c1.ToString());
Customer c2 = new Customer(1, "Mikkel", "Alleen 321", "13131313");
//Console.WriteLine(c2.ToString());
Customer c3 = new Customer(1, "Charlotte", "vej 111", "14141414");
//Console.WriteLine(c3.ToString());

Order order1 = new Order(p1, c1, true);

Order order2 = new Order(p2, c2, false);

Order order3 = new Order(p3, c3, true);
order1.PrintReciept();
order2.PrintReciept();
order3.PrintReciept();