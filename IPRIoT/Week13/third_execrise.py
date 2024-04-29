from math import pi
class Shape:
    def __init__(self,name):
        self.name = name

    def area(self):
        print("unknown")

class Square(Shape):
    def __init__(self,name,lenght):
        super().__init__(name)
        self.lenght = lenght

    def area(self):
        return self.lenght * self.lenght


class Rectangle(Shape):
    def __init__(self, name, lenght, width):
        super().__init__(name)
        self.lenght = lenght
        self.width = width

    def area(self):
        return self.lenght * self.width


class Triangle(Shape):
    def __init__(self, name, height, base):
        super().__init__(name)
        self.height = height
        self.base = base

    def area(self):
        return (self.height * self.base)/2

class Circle(Shape):
    def __init__(self,name,radius):
        super().__init__(name)
        self.radius = radius

    def area(self):
        circle_area = round((self.radius * self.radius * pi),2)

        return circle_area

obj1 = Square("Square",5)
print("The area of",obj1.name,"with the lenght of",obj1.lenght,"is",obj1.area())
obj2 = Rectangle("Rectangle",5,4)
print("The area of",obj2.name,"with the lenght of",obj2.lenght,"and width of",obj2.width,"is",obj2.area())
obj3 = Triangle("Triangle",3,5)
print("The area of",obj3.name,"with the height of",obj3.height,"and base of",obj3.base,"is",obj3.area())
obj4 = Circle("Circle",4)
print("The area of",obj4.name,"with the radius of",obj4.radius,"is",obj4.area())

# for pi value import pi as shown on top
# to round up values use round("the value that you want to round up" , "the number of places after comma" )