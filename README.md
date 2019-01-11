As with assignment 1, develop a simple set of Java/C# classes using the Observer pattern to represent the following scenario:

In the land of Middle Earth battle wages between good and bad.  On the side of 'good' are Hobbits, Elves, Dwarves, and Men.  On the side of 'bad' are the wizard Saruman and the Witch King of Angmar (leader of the Nazgul).  The ever watching Eye of Sauron is always on the lookout for the agents of 'good'.  Saruman and the Witch King would like to be notified any time the Eye of Sauron spots one of the good guys.

Use the Observer pattern to model the above.  Properly utilize Java's Observer interface and Observable class as part of your implementation.  If you use C#, utilize the .NET counterparts (IObservable and IObserver).  Use the tester class given below as a starting point for your design (you may add more to the tester as necessary based on your solution to this problem).  Follow the Weather Data example from HFDP to aid you in your task.  Turn in a zip that contains your source files and a UML representation (.pdf required) of the classes and interfaces in your design.
```
public class TestSauronEye {
    public static void main(String[] args) {

        EyeOfSauron eye = new EyeOfSauron();
        BadGuy saruman = new BadGuy(eye, "Saruman");
        BadGuy witchKing= new BadGuy(eye, "Witch King");
        eye.setEnemies(1, 1, 2, 0); //hobbits, elves, dwarves, men -- BTW, this is HORRIBLE coding style and a bad code smell
        //message should be displayed from Saruman and Witch Kingthat they know about 1 hobbit, 1 elf, 2 dwarves
        
        saruman.defeated(); //Saruman is no longer registered with the Eye
        eye.setEnemies(4, 2, 2, 100);
        //only the Witch King reports on the enemies

    }//end main
}//end class
```
Rubric
Observer Rubric
Observer Rubric
Criteria	Ratings	Pts
This criterion is linked to a Learning Outcome UML Class Diagram
.pdf format, proper symbols used for class relationships, visibility symbols used for fields and methods, labels for <<interface>> and <<abstract>> classes
8.0 pts
This criterion is linked to a Learning Outcome Source code
implements required Observer and Observable, fields are declared with private (or if necessary protected) visibility, solution allows for registering, unregistering of observers and subject properly notifies observers
12.0 pts
This criterion is linked to a Learning Outcome Misc
proper files submitted, code clean and easy to follow with good naming conventions, etc.
5.0 pts
Total Points: 25.0
