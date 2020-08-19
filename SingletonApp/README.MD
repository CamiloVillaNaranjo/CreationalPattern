# SingletonApp Project

In this project I translate the concepts learned in the course of Udemy entitled **Design patterns and SOLID principles**. The idea is to have a record of my progress in that course, for future reference.

## Singleton Pattern:
### Definition:

It is a creational Pattern, which ensures that only one object of its kind exists and provides a single point of access to it for any other code.

### Problem

This pattern solves two problems at the same time, so is violating the _Single Responsability Principle_:
1. **Ensure that a class has just a single instance**. 
2. **Provide a global access point to that instance**.

### Solution

All implementations of the Singleton have these two steps in common:
* Make the default constructor Private, to prevent other objects from using the `new` operator with the Singleton class.
* Create a static creation method that acts as a constructor.