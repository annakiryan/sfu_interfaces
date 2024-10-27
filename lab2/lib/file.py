from lib.parse_line import parse_line

class File:
    def __init__(self, filepath: str):
        self.filepath = filepath
        self.objects = []


    def load_objects(self):
        try:
            with open(self.filepath, 'r') as file:
                for line in file:
                    if line.strip():
                        obj = parse_line(line.strip())
                        if obj:
                            self.objects.append(obj)
                        else:
                            raise ValueError("неверный формат строки - " + line.strip())
                    
        except FileNotFoundError as e:
            raise Exception(e)
            
    
