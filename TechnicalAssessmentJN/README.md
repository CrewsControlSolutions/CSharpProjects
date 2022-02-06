<h1>Squigly Bracket Pair {} Checker</h1>

<p>This simple console application checks whether a passed string contains only valid (inward facing) pair/s of squigly brackets. Invalid (outward facing) squigly bracket pair/s and squigly bracket/s without a mate do not pass the test.</p>

<h2>Sections:</h2>
<ul>
  <li><h4><a href="https://github.com/CrewsControlSolutions/CSharpProjects/blob/main/TechnicalAssessmentJN/TechnicalAssessmentJN/BracketChecker.cs">Squigly Bracket Pair Checking Method</a></h4></li>
  <li><h4><a href="https://github.com/CrewsControlSolutions/CSharpProjects/blob/main/TechnicalAssessmentJN/UnitTest/BracketTest1.cs">Unit Testing</a></h4></li>
</ul>
 
 <h4>Bracket Pair Checking Method</h4>
 <p>
  This method receives a parameter of type string and returns a boolean value. The logic is as follows. If the string contains only valid (inward facing) bracket pairs (e.g.  "{}" ,  "{abc...xyz}" , or  "{ {}{} }" ), then the method returns True. The method also returns True if the passed string is empty (i.e. ""). Otherwise, the method returns False. If a null value is passed to the method, a NullReferenceException error is thrown. The time complexity is O(n). The space complexity is O(1).
 </p>
 
 <h4>Unit Testing</h4>
 <p>
  Unit testing consists of several isolated, minimally passing test cases. All tests can be executed at once using the xUnit.Net testing framework. Each test is structured using the Arrange, Act, Assert pattern. Variations of arranged strings are utilized across the test cases, including the edge cases of an empty string and a null value.
 </p>
