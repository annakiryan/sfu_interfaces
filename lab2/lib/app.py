from lib.file import File
from lib.args import args
from lib.action import Action
from sys import exit

class App:
   def __init__(self):
      self.file = File(args.file)
      self.oper = args.oper
   

   def load_file(self):
      try:
         self.file.load_objects()
      except Exception as e:
         print('Произошла ошибка:', e)
         exit(1)

   
   def run(self):
      self.load_file()

      match self.oper:
         case Action.PRINT:
            self.__print_obj(self.file.objects)
         case Action.COUNT:
            self.__count_obj(self.file.objects)
         case Action.SQUARE:
            self.__square(self.file.objects)
         case _:
            print('Неизвестная команда')   


   def __print_obj(self, objects):
      for obj in objects:
         print(obj)


   def __count_obj(self, objects):
      print(len(objects))

   def __square(self, objects):
      for obj in objects:
         print(obj.area())

            

    