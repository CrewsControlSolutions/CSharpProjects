<h1>Bracket Pair {} Checker</h1>

<p>This simple console application checks whether a passed string contains only matching pairs of brackets. It is divided into two sections.</p>

<h2>Sections:</h2>
<ul>
  <li><h4><a href="https://github.com/CrewsControlSolutions/CSharpProjects/blob/main/TechnicalAssessmentJN/TechnicalAssessmentJN/Program.cs#L29">Bracket Pair Checking Method</a></h4></li>
  <li><h4><a href="https://github.com/CrewsControlSolutions/CSharpProjects/blob/main/TechnicalAssessmentJN/TechnicalAssessmentJN/Program.cs#L8">Unit Testing</a></h4></li>
</ul>
 
 <h4>Bracket Pair Checking Method</h4>
 <p>
  This method receives a parameter of type string and returns a boolean value. The logic is as follows. If the string contains only matching bracket pairs (e.g.  "{}" ,  "{abc...xyz}" , or  "{ {}{} }" ), then the method returns "true." The method also returns "true" in the edge case where the passed string contains no content (i.e. ""). If neither of these conditions are met, the method returns "false."
 </p>
 
 <h4>Unit Testing</h4>
 <p>
  Unit testing consists of passing eight (8) different types of strings to the method. One can simply choose between these types or create a different string. All code for unit testing takes place within the Main method and does not affect the external bracket pair checking method.
 </p>
