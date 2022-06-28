<img align="right" src="https://refactoring.guru/images/patterns/content/factory-method/factory-method-en.png"/>
<p><h2>Factory method 🏭</h2><i>Provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.</i></p>
<h3>Bullet points 🛸</h3>
<ul>
  <li>Factory Method relies on
inheritance: object creation is
delegated to subclasses which
implement the factory method to
create objects.</li>
  <li>The intent of Factory Method
is to allow a class to defer
instantiation to its subclasses.</li>
  <li>Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.</li>
  <li>The Factory Method separates product construction code from the code that actually uses the product. Therefore it’s easier to extend the product construction code independently from the rest of the code.</li>
  <li>Use the Factory Method when you want to provide users of your library or framework with a way to extend its internal components.</li>
</ul>
<h1>Class diagram 👀</h1>
<img align="left" src="https://refactoring.guru/images/patterns/diagrams/factory-method/structure.png"/>
