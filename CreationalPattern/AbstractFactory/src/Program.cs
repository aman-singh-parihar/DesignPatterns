using AbstractFactory;

IFactory factory = new ContemporaryFactory();
Client c = new Client(factory);
c.CreateChair();
c.CreateTable();

factory = new ClassicFactory();
c = new Client(factory);
c.CreateTable();
c.CreateChair();