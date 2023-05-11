using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        // ask yourself, "what is a deck?"  --  it is a collection of 52 cards  --  we can use a 'List' data type to define this as it is easy to use

        // 12. a. Adding a very usful constructor -- constructors always go at the top of the class before the properties and assign values immediately upon creation:
        public Deck()
        {
            //// 13. comment the code below out
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            // 16. inside of the constructor (the method that is being called as soon as the obj. is created -- completely different than the class) add syntax that refers to the 'Property' of the class 'Deck'  --  do not need to give it a data type or variable name b/c it already has one (its the property of that class) -- pop back down to step 17
            Cards = new List<Card>();

            // 14. a. new solution logic - deck of card had 13 "faces" of cards = 'Ace,2,4,5,6,7,8,9,10,jack,queen,king' and each card has 4 'suits' = 'Hearts, Clubs, Spades, Diamonds' = 52 cards
            // for each 'face' in that list of 13, we need to loop through it 4 (number of suits -- "one loop for each suit) times (13 * 4 = 52)
            // result of that will be what is called a "Nested for loop" or in this case a "Nested foreach loop"

            // 14. b. first thing we have to do is create a list of all the possible 'Suits'  -- instanciate it right when we create it so that 4 suits are now inside the new List of type 'Suits'
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            // 14. c. next create another list of type 'Faces' & instanciate it with the 13 'faces' the cards will have
            List<string> Faces = new List<string>() 
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            // 15. the idea is to loop through both of these lists we've created almost simultaineouly in order to generate a deck of 52 cards, one of each combination using a 'foreach' loop
            foreach (string face in Faces) 
            {
                foreach (string suit in Suits)
                {
                    // "for each item in the list we'll loop through each suit on each face"  --  loop through Suits items 4 times  -- first, create a new card
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    // next add that card to the List -- go up to step 16 before adding the next line of code

                    // 17. add the code line below  -- once done, read the summary below then head to the 'Program' file to step 18
                    Cards.Add(card);
                    // Summary of these recent steps: "Inside our class we have a constructor which is a method that is called as soon as an object is created. First thing it does is instantiate it's Property 'Cards' as an empty List of cards (creation of assigned values must be done w/ a list). Then it creates 2 more lists and immediately instantiates them w/ values. The first List is called Suits and is given the values clubs, hearts, diamonds, and spades. The next List is called Faces and its given 13 face values 2 through Ace. End up w/ 2 Lists, one with 4 items and one with 13 items and 13 times 4 is 52 which is the total amount of cards in this deck. So for each of the face itemes in the Faces list, we loop through 4 times (the amount of items in Suit). During each loop, a card is created and we assign the suit property the value of Suit and the face the value of Face. Then the program add that newly created card into the Cards List created on step 16. The variable 'card' only exsists inside of each loop. Once the loop ends, the Card card = new Card() aka 'card' variable doesn't exsist anymore which is why it can be created over and over again with the same name."
                }
            }



            // 12. b. now lets choose the easiest/best code path in our creation of thie 52 card deck  --  hop over to 'Program' file to step 12 c
        }

        // 9. give the class a public PROPERTY of data type List<Card> (it is a list of cards)  --  then go back to the 'Program' class file to officially create a deck of cards object step 10
        public List<Card> Cards { get; set; }
    }
}
