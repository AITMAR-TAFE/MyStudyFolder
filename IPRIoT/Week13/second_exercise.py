from abc import ABC, abstractmethod

class Polygon(ABC):

    #@abstractmethod
    def NumberOfSides(self):
        print("Unknown")

class Triangle(Polygon):
    pass
    #def NumberOfSides(self):
        #print("Triangle has 3 sides")

class Quadrilateral(Polygon):
    def NumberOfSides(self):
        print("Quadrilateral has 4 sides")

class Pentagon(Polygon):
    def NumberOfSides(self):
        print("Pentagon has 5 sides")

obj1 = Triangle()
obj1.NumberOfSides()
obj2 = Quadrilateral()
obj2.NumberOfSides()
obj3 = Pentagon()
obj3.NumberOfSides()