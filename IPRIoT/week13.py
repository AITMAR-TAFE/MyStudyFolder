class User:
    def __init__(self, name, ID):
        self.name=name
        self.ID=ID

class Student(User):
    def __init__(self, name, ID, marks):
        super().__init__(name, ID)
        self.marks = marks

    def student_info(self):
        print("This Student name is ",self.name, )



object1 = Student("Peter",2011400,100)
object1.student_info()
print(type(object1) is Student)