from PyQt5.QtWidgets import QWidget, QPushButton, QGridLayout, QMessageBox
from playwidget import PlayWidget
from settingwidget import SettingWidget
from recordswidget import RecordsWidget
import json


class Menu(QWidget):
    DEFAULT_RECORD_PATH = "records.json"

    def __init__(self):
        super().__init__()
        self.init_ui()
        self.play_widget = None
        self.setting_widget = None
        self.records_widget = None

    def init_ui(self):
        self.setWindowTitle("Меню")
        self.create_buttons()
        self.create_layout()

    def create_buttons(self):
        self.play_button = QPushButton("Играть", self)
        self.setting_button = QPushButton("Настройки", self)
        self.records_button = QPushButton("Статистика", self)
        self.push_me = QPushButton("Нажми", self)

        self.play_button.clicked.connect(self.play_clicked)
        self.setting_button.clicked.connect(self.setting_clicked)
        self.records_button.clicked.connect(self.records_clicked)
        self.push_me_button.clicked.connect(self.push_me_clicked)


    def create_layout(self):
        layout = QGridLayout(self)
        layout.addWidget(self.play_button, 0, 0)
        layout.addWidget(self.setting_button, 1, 0)
        layout.addWidget(self.records_button, 2, 0)

    def play_clicked(self):
        self.show_widget(PlayWidget, "play_widget")

    def setting_clicked(self):
        self.show_widget(SettingWidget, "setting_widget")

    def records_clicked(self):
        record_path = self.get_record_path()
        data = self.load_record_data(record_path)
        
        if data is not None:
            self.show_widget(RecordsWidget, "records_widget", data)

    def push_me_clicked(self):
        self.QLabel("Привет, Мир", self)

    def closeEvent(self, event):
        self.close_open_widgets()
        event.accept()

    def get_record_path(self):
        if self.setting_widget and self.setting_widget.record_path:
            return self.setting_widget.record_path
        return self.DEFAULT_RECORD_PATH

    def load_record_data(self, record_path):
        try:
            with open(record_path, 'r') as f:
                return json.load(f)
        except (FileNotFoundError):
            QMessageBox.critical(self, "Ошибка", "Файл рекордов не найден")
            return None

    def show_widget(self, widget_class, widget_name, *args):
        widget = getattr(self, widget_name)
        if widget is None:
            widget = widget_class(*args)
            setattr(self, widget_name, widget)
        widget.show()

    def close_open_widgets(self):
        for widget in [self.play_widget, self.setting_widget, self.records_widget]:
            if widget:
                widget.close()
