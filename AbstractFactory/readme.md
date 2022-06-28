<img style="width:500px;height:300px" align="right" src="https://user-images.githubusercontent.com/25085025/176226896-1b660b7b-99af-42c1-8379-09ddccf5f20d.png"/>

<p><h2>Abstract factory</h2> - 🏭: <i>The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.</i></p>

<img style="width:300px;height:300px" align="right" src="https://user-images.githubusercontent.com/25085025/176226898-59c95140-7da8-4e2d-9235-e43534a0bb55.png">

<h3>Bullet points 💃</h3>
<ul>
  <li>Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.</li>
  <li>Abstract Factory relies on object composition: object creation is implemented in methods exposed in the factory interface.</li>
  <li>Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.</li>
  <li>Open/Closed Principle. You can introduce new variants of products without breaking existing client code.</li>
  <li>The Dependency Inversion Principle guides us to avoid dependencies on concrete types and to strive for abstractions.</li>
</ul>

<h1>Class diagram 🍾:</h1>
<img align="left" src="https://user-images.githubusercontent.com/25085025/176226890-4b75f626-3a8a-4667-a199-b3f9d73860b6.jpg"/>
