<img align="right" height="550" width="640" src="https://user-images.githubusercontent.com/25085025/74012750-6bc8b000-49a4-11ea-836d-c7e8e799632f.png"/>
<p><h2>Command :tv:</h2><i>Encapsulates a request as an object, thereby letting you parametrize clients with different requests, queue or log requests, and support undoable operations.</i></p>
<h3>Bullet points :calling:</h3>
<ul>
  <li>The Command Pattern decouples an object, making a request from the one that knows how to perform it.</li>
  <li>A Command object is at the center of this decoupling and encapsulates a receiver with an action (or set of actions).</li>
  <li>An invoker makes a request of a Command object by calling its execute() method, which invokes those actions on the receiver.</li>
  <li>Invokers can be parameterized with Commands, even dynamically at runtime.</li>
  <li>Commands may support undo by implementing an undo method that restores the object to its previous state before the execute() method was last called.</li>
  <li>Commands may also be used to implement logging and transactional systems.</li>
  <li>You can implement more than one facade for a subsystem.</li>
</ul>
<h1>Class diagram :six_pointed_star:	</h1>
<img align="left" src="https://user-images.githubusercontent.com/25085025/74012523-e3e2a600-49a3-11ea-9830-4c21a55fff0a.png"/>
