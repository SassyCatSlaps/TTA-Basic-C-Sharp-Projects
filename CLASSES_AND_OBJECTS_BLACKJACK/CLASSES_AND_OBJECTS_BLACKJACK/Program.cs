using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
    // Creating the game TwentyOne aka BlackJack

    // Refactoring this code as I go -- notes/comments are for myself so that I can follow along with the though process as I learned this -- these comments walk you through step by step
{


    class Program
    {
        static void Main(string[] args)
        {

            // 10. a. Create an object of data type 'Deck' aka "lets create a deck of cards --  instantiate an object called Deck and assigned it to the variable deck" using the syntax below:
            Deck deck = new Deck();

            // 24. we need to now call the new Method 'Shuffle' that was just created  --  Shuffle takes a parameter and returns a deck -- we need something to return the deck to -- asign it to:
            deck = Shuffle(deck);
            // shuffles the 'deck' and returns that value back to it e.g. reasigning the value to that variable (and then we'll print it out to test it F5)
            // if we comment out the line of code 'deck = Shuffle(deck);' and print again we will see the deck inorder

            // 18. a. above is the "newly created Deck" line of code -- upon instantiating that object it should have an entire deck of 52 cards
            // "Deck object which has a property Cards, that Cards List should have 52 unique cards in it e.g. one of each card in a standard deck of cards"

            // 18. b. in order to print all so that we can see it we have to create another foreach loop -- after writing the code below comment out the console.writeline at step 12 c
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            // 18. c. we're also going to print out the length of that list so we can see that it is 52 using '.Count'
            // Cards is a Property of deck and Cards is of data type List<Card>  -- List has a property called 'Count' which is what gets called in this line of code:
            Console.WriteLine(deck.Cards.Count);
            // ** leave this readline in for the entirty of this code assignment
            Console.ReadLine();
        }
            // Sweet! with just a few lines of code, we have a whole deck of cards... now, how do we shuffle it? -- time to cover 'Methods' aka 'Functions/Routines' = "little blocks of reusable code that do something.
            // Compossed of an access modifier that comes first that asks, 'is this Method acessable everywhere in the program or just this class?'. Also composed of a 'Return type' = 'void' which means it returns nothing. Methods also contain parameters or lack of parameters'()' -- the one above in the 'Main' method takes a string array '[]' called args (arguments) as a parameter if there is a parameter there.
            // Methods also have to be part of a class. If a Method is being used without first creating an object of that class the it has to be marked as 'static' which is also seen above, nested within the brackets of the 'class Program' code line."
            // When do we use Methods?  --  lets use them to shuffle the perfectly ordered Deck of cards anytime to dealer feels like it to prevent cheating
            // dealer will be able to call the "Shuffle" Method and then those cards will be shuffled  --  to break down the thought process, we want a method that takes a List of cards and returns a shuffled deck of cards. the method would need to have a 'Return type' of deck and would also take a deck as a type of argument. i.e. "Take in a deck and Return a deck"

            // 19. Lets write out the method logic breakdown above -- type below the 'Main' method (meaning outside of its brackets but still within the 'class Program' brackets) write:
            public static Deck Shuffle(Deck deck)
            // static = we dont want to have to create and obj program | calling Deck = what is being returned - the type of data | Shuffle = name of the function | (Deck deck) = takes a parameter of type Deck and is given the variable name 'deck' so we can refer to it inside of our Shuffle Method
            {
                // 21. create a temporary list of type Card that is empty where we can store our shuffled items -- after this we need to create a 'while' loop below
                List<Card> TempList = new List<Card>();

                // what to put inside this method? Shuffling should be random and differnt each time. How do we create randomness? Lots of different ways and opinions on it.
                // 20. C# has a class called the "Random class" (thanks to framework class library) that helps us out with making things random -- use the syntax below:
                Random random = new Random();
                // this is a hard method to create! no worries, just push through! -- now jump above this step to step 21 to create a new list 

                // 22. a. our while loop  --  grab a rando card, take it out of the deck, put it into a temporary deck and do that until deck.Cards.Count is at 0
                while (deck.Cards.Count > 0)
                {
                    // 22. b. create a random index to do the grabbing -- has a min & max value  -- from 0 - 52 then add it our temporary list deck.Cards[randomIndex]
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                // 23. now take your deck.Cards which is empty and assign the TempList to it as a value and return the deck  -- once code below is writen, go up to step 24
                deck.Cards = TempList;
                return deck;
            }

            // 10. b. lets give it some values  --  it has one property 'deck.Cards' (Cards is a List we created in the 'Deck' file) and now we're creating a 'new List<>()'
            // inorder to assign anything to a list you have to first instantiate it with the 'new' keyword -- "We've instantiated the data type "List<Card>" 

            // 10. c. commented this line out for step 12 c. console print test  
            //deck.Cards = new List<Card>(); 
            // now we can add card to this property of the deck called 'Cards' (again, 'Cards' was defined on in the Deck file)  --  see step 11 below -- scroll down for step 11 a & b

            // 12. c. let's just test print the code that we just input over on the 'Deck' file  --  shows that the deck constructor is creating a cards list and adding one card to it
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            // output should be 'Two of Hearts' at that point in writing the code... hop back to the 'Deck' file now for step 13
            // this substep will get commented out to make way for step 18 b

            // 1. a. lets make a class called 'card' first:

            // 1. b. For these first steps, I will be creating states  ---  create basic models for objects called classes
            // *** Go to Solution Explorer, right click what you named your project (in this case 'TwentyOne'), go to 'Add', then select 'class', when window pops up select 'Class'
            // then at the bottom of the window name your new class 'Card' and click the 'Add' button on the bottom right. You will now see your new class in the Solution Explorer drop down and it will even have a new, seperate tab from your 'Program.cs' tab at the top called 'Card.cs'. We only want one class per file/tab  --  go to the new 'Card' file to step 2

            // 5. once thats done and we've defined 2 new properties in our 'Card' class, we can now go into this 'Program' class and define an object that is of the 'Card' class

            // 6. a. Create a 'Card' object with the following syntax:
            // the line below translates to: " Created an object of data type 'Card' and assigned it to the Variable 'cardOne' "
            //Card cardOne = new Card();
            //// the object as created is empty meaning there are no values assigned to it -- lets assign some values! -- when you press '.' after typing the variable, the program will show you a drop down of options including properties of the obj and built in methods avialable to you

            //// 6. b. "Assigned the string Queen to the property 'Face' of the object cardOne && assinged string Spades to the property 'Suit' of the obj cardOne"

            //// 11. a. commented these values below out temp to demonstraight using a constructor -- then for the Constructor EXAMPLE in the 'Class' file I've uncommented them again
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //// 7. a. Create a card:
            //deck.Cards.Add(cardOne);
            // 7. b.lets take a peak at what we've created using the syntax below:
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            // 8. Now lets create another class to explore constructors -- use the directions in step 1 to create a new class called "Deck" then go to that file to do more work! ***

            // 7. c. great, we've added a card to the deck... but w/ 52 cards, to add each one to the deck will get pretty tedious and annoying = too much time and typing! so what do we do now?
            // this brings you back to using a 'Constructor' (example syntax in 'Card' file/tab)  --  the Card class may not need a constructor but the Deck class will!

            // 11. b. Time to delete/comment out the value fill-ins we've done in this file and go create a constructor in the 'Deck' class! (go to 'Deck' tab now)  
    }
}
