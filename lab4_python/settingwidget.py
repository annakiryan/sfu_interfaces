from PyQt5.QtWidgets import QWidget, QLabel, QLineEdit, QPushButton, QGridLayout, QMessageBox
import os
from validation import validate_json_file


class SettingWidget(QWidget):
    def __init__(self, parent=None):
        super().__init__(parent)
        self.record_path = None
        self.setup_ui()
        
    def setup_ui(self):
        """Настройка пользовательского интерфейса."""
        layout = QGridLayout(self)

        enter_path_label = QLabel("Введите путь к таблице рекордов:", self)
        self.path_input = QLineEdit(self)
        save_button = QPushButton("Сохранить", self)
        
        layout.addWidget(enter_path_label, 0, 0)
        layout.addWidget(self.path_input, 0, 1)
        layout.addWidget(save_button, 1, 0, 1, 2)
        
        save_button.clicked.connect(self.save_pressed)

    def save_pressed(self):
        """Обработчик нажатия кнопки сохранения."""
        path = self.path_input.text()
        
        is_valid, errors = self.is_valid_path(path)
        if is_valid:
            self.record_path = path 
            QMessageBox.information(self, "Успех", "Путь сохранен")
            self.close()
        else:
            QMessageBox.critical(self, "Ошибка", "\n".join(errors))

    def is_valid_path(self, path):
        """Проверяет, существует ли путь и является ли он корректным."""
        if os.path.exists(path):
            is_valid, errors = validate_json_file(path, ['name', 'score'])
            return is_valid, errors
        else:
            return False, ["Указанный путь не существует."]
