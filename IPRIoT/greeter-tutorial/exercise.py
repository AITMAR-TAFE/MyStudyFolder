class Calculation:
    def __init__(self, number1, number2):
        self.number1=number1
        self.number2=number2

    def add(self):
        return self.number1+self.number2

    def subtract(self):
        return self.number1-self.number2

    def multiply(self):
        return self.number1*self.number2

    def divide(self):
        return self.number1/self.number2


userinput1 = int(input("Please write your first number here: "))
userinput2 = int(input("Please write your second number here: "))


object1 = Calculation(userinput1, userinput2)
print("The result of addition is ",object1.add())
print("The result of subtraction is ",object1.subtract())
print("The result of multiplication is ",object1.multiply())
print("The result of division is ",object1.divide())

