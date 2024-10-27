import abc
import math
class Shape(abc.ABC):
    @abc.abstractmethod 
    def area (self): pass

class Point(Shape):
    def __init__(self, x, y):
        self.x = float(x)
        self.y = float(y)
    
    def __repr__(self):
        return f"Point({self.x}, {self.y})"
    
    def area (self):
        return 0

class Line(Shape):
    def __init__(self, start, end):
        self.start = start
        self.end = end
    
    def __repr__(self):
        return f"Line({self.start}, {self.end})"
    
    def area(self):
        return 0

class Circle(Shape):
    def __init__(self, center, radius):
        self.center = center
        self.radius = float(radius)
    
    def __repr__(self):
        return f"Circle({self.center}, {self.radius})"
    
    def area(self):
        return math.pi * self.radius**2