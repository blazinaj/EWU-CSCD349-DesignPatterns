Assignment 1: Strategy Pattern
Jimi Hendrix Cartoon Picture     Telecaster Tux

The upcoming Guitar Hero VIII: Legends of Rock needs a player configuration system. Guitar Hero VIII lets you play three different characters (Slash, Jimi Hendrix, and Angus Young). Each character can use one of three different guitars (Gibson SG, Fender Telecaster or Gibson Flying V) as well as perform a unique solo act (Put the Guitar on Fire, Jump off the Stage, Smash the Guitar).  Implement a player configuration system in Java or C# using the Strategy design pattern.  You should have separate classes to represent each of the components specified.  
 

Include a UML class diagram (as a .pdf) that represents your class relationships as part of your submission.  You are free to use any editing tools you wish.  Eclipse has a nice UML class diagram tool that will even generate the UML based on existing code.  Note however that it does not always build the class diagram correctly -- you should stay away from this tool until you have a good understanding of the components of a UML class diagram.  A reasonably good UML drawing program is Draw.IO (There will be a demo of this in class).  TinyUML is also pretty good.  You are welcome to use whatever you like *as long as it supports the basic UML symbols required for class diagrams -- we will go over these in class*. 
While we will discuss them in class, an excellent tutorial on the basics of class diagrams lives here: http://www.agilemodeling.com/artifacts/classDiagram.htm (Links to an external site.)Links to an external site.

Here’s a class containing the Java main method to help you on your way.  Note that the contents of this class are not exhaustive with respect to your assignment.  More specifically, add items to the main method to show dynamic swapping of behaviors.  

public class GuitarHero {
    public static void main(String[] args) {
        GameCharacter player1 = new GameCharacterSlash(); //note that constructor could be designed to accept initial behaviors
        GameCharacter player2 = new GameCharacterHendrix();
        player1.playGuitar();
        player2.playGuitar();
        player1.playSolo();
        player2.playSolo();

        //add code below to show the swapping of behaviors
    }
}

Hint1: You should use the Java Duck example from Chapter 1 of HFDP.
Hint2: It helps if you draw a class diagram *before* you start coding. 


Your submission must include .java/.cs files and the .pdf that contains the UML representation of your classes.  These items must be placed in a .zip file that is named with your name, followed by cscd349as1 (e.g. capaultom_cscd349as1.zip)