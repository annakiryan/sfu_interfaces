import lib.figures as f
import re

def parse_line(line):

    point_pattern = r'Point\(([-+]?\d*\.\d+|\d+),\s*([-+]?\d*\.\d+|\d+)\)'
    line_pattern = rf'^Line\({point_pattern},\s*{point_pattern}\)$'
    circle_pattern = rf'^Circle\({point_pattern},\s*(\d+)\)$'
    
    point_match = re.match(point_pattern, line)
    line_match = re.match(line_pattern, line)
    circle_match = re.match(circle_pattern, line)
    
    if point_match:
        return f.Point(*point_match.groups())
    elif line_match:
        return f.Line(f.Point(*line_match.groups()[0:2]), f.Point(*line_match.groups()[2:4]))
    elif circle_match:
        return f.Circle(f.Point(*circle_match.groups()[0:2]), circle_match.group(3))
    else:
        return None
    


