from argparse import ArgumentParser
from lib.action import Action

parser = ArgumentParser(description='Обработка фигур')

parser.add_argument('-f', '--file', metavar='filename', type=str, required=True, help='Имя файла с фигурами')

parser.add_argument('-o', '--oper', metavar='command', type=Action, default=Action.PRINT, help='Операция над фигурами')

parser.add_argument('-v', '--version', action='version', version='%(prog)s 1.0')

args = parser.parse_args()




    
   