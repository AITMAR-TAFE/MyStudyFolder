class Users:
    def __init__(self, name, id):
        self.name = name
        self.id = id


class Student(Users):
    def __init__(self,name, id, marks):
        super().__init__(name,id)
        self.marks = marks

    def method1(self):
        print("Student name is ", str(self.name), " and student id is ", str(self.id))
    pass


class Teacher(Users):
    def __init__(self,name, id, designition):
        super().__init__(name,id)
        self.designiton = designition

    def method1(self):
        print("Teacher name is ", str(self.name), " and teacher id is ", str(self.id))
    pass

object1 = Student("Jack",2011300,80)
object1.method1()
object2 = Teacher("Mary",2012999,"Math teacher")
object2.method1()

