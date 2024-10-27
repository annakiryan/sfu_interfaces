import os
import json

def validate_json_file(file_path, required_fields):
    """Проверяет, существует ли файл и соответствует ли он требованиям."""
    if not os.path.isfile(file_path):
        return False, ["Файл не существует."]

    try:
        with open(file_path, 'r', encoding='utf-8') as f:
            data = json.load(f)

        return validate_data(data, required_fields)
    except json.JSONDecodeError:
        return False, ["Файл не является корректным JSON."]
    except Exception as e:
        return False, [f"Произошла ошибка: {str(e)}"]

def validate_data(data, required_fields):
    """Проверяет, соответствует ли содержимое JSON-файла заданным требованиям."""
    if not isinstance(data, list):
        return False, ["Файл должен содержать массив объектов."]
    
    for entry in data:
            if not isinstance(entry, dict):
                return False, ["Каждый элемент должен быть объектом."]
            for field in required_fields:
                if field not in entry:
                    return False, [f"Отсутствует необходимое поле: {field}"]
    
    return True, []

