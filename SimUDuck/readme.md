<img align="right" src="https://refactoring.guru/images/patterns/content/strategy/strategy-comic-1-en.png"/>
<p><h2>Strategy 📏</h2><i>Defines a family of algorithms,
encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from
clients that use it.</i></p>
<h3>Bullet points 👽</h3>
<ul>
  <li>You can swap algorithms used inside an object at runtime. But if you only have a couple of algorithms and they rarely change, there’s no real reason to overcomplicate the program with new classes and interfaces that come along with the pattern.</li>
  <li>You can isolate the implementation details of an algorithm from the code that uses it.</li>
  <li>Open/Closed Principle. You can introduce new strategies without having to change the context.</li>
  <li>A lot of modern programming languages have functional type support that lets you implement different versions of an algorithm inside a set of anonymous functions. Then you could use these functions exactly as you’d have used the strategy objects, but without bloating your code with extra classes and interfaces.</li>
</ul>
<h1>Class diagram 😽</h1>
<img align="left" src="https://refactoring.guru/images/patterns/diagrams/strategy/structure.png"/>
