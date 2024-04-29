class Users:
    def __init__(self, name, id, responsibility):
        self.name = name
        self.id = id
        self.responsibility = responsibility

    def duty (self):
        return f"The responsibility of ", self.name, " is to ", self.responsibility


class Student(Users):
    def __init__(self,name, id, responsibility):
        super().__init__(name, id, responsibility)

    pass


class Teacher(Users):
    def __init__(self,name, id, responsibility):
        super().__init__(name,id, responsibility)

    pass


class Admin(Users):
    def __init__(self,name, id, responsibility):
        super().__init__(name,id, responsibility)

    pass


object1 = Student("Jack",2011300,"to study")
object2 = Teacher("Mary",2012999,"to teach")
object3 = Admin("Kate", 29991010,"to administer")


for a in [object1, object2, object3]:
    print(a.duty())
