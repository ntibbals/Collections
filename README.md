### Lab07-Collections

## Summary

- This is a card dealing application that utilizes generic collections to hold a deck of cards. Upon running the application, an initial sample deck will output and then another deck will be created at which point a shuffle to two players will occur. The remaining unshuffled cards will remain in the dealers hand.

## Specifications

- Two methods are being called in the main method upon running the application, CreateDeck() and Deal().

- This application utilizes generic collections to hold the instantiated objects.

- Enums are stored within the Card class for Suit properties applied to each object.

-Enumerable interfaces are implemented with the collections as well to assist with the Add, Remove and count methods built to manipulate the collections.


## Usability

- Upon page load, ten sample cards are displayed with their card value and suit. The application will then create another deck to deal to Player One, Player Two and the Dealer. Each player recieves five cards and the remaining cards stay in the dealers hand.

# Creating Deck
![SCREENSHOT](https://github.com/ntibbals/Lab07-Collections/blob/master/image1.PNG)

# Removing Cards
![SCREENSHOT](https://github.com/ntibbals/Lab07-Collections/blob/master/image2.PNG)

# Dealing
![SCREENSHOT](https://github.com/ntibbals/Lab07-Collections/blob/master/image2.PNG)


# Resources

https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netframework-4.7.2

https://stackoverflow.com/questions/5320592/value-is-in-enum-list

https://stackoverflow.com/questions/31508180/how-to-remove-an-enum-item-from-an-array