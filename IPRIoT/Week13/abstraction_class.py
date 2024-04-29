#An abstract class is a class that cannot be instantiated and is used only to define a blueprint for other classes. An interface is a class that contains abstract methods (methods without a concrete implementation) and is used to define a contract for other classes.

#In Python, we can use the abc module to create abstract classes and interfaces. An ABC (Abstract Base Class) is a mixin - it can be used to define both abstract methods and concrete methods, but regardless an ABC cannot itself be instantiated.

from abc import ABC, abstractmethod

class Animal(ABC):
    def __init__(self,name):
        self.name = name

    @abstractmethod
    def speak(self): ...

class Dog(Animal):
    def speak(self):
        print(f"I am a dog: {self.name}")

class Cat(Animal):
    pass

dog = Dog("Sky")
dog.speak()
cat = Cat("Bob")
cat.speak()
