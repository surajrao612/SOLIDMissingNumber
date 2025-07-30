# SOLIDMissingNumber

### Project Details:

This task is to find the missing number in a given list of integers.

##### Objective:
Use SOLID principles to implement the solution

##### Implementation:

1. Single Responsibility:
Example *SolutionWithLoop* and *SolutionWithArray* classes have single purpose to find the missing number
2. Open Closed Principle
*IMissingNumberService* interface logic can be interpreted as required without modifying it.
3. Liskov Substitution
Subtype implementations can be replaced for the original without error.
4. Interface Segregation
*IMissingNumberService* is a simple interface which does not force classes to implement methods they do not require.
5. Dependency Inversion
In *MissingNumberProcessor* dependencies are injected to the class instead of concrete inplementations. Implementation can be changed without affecting the code. This also helps with unit testing making it easier to test by lossely coupling the code.
