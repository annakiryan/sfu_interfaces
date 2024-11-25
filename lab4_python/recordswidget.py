from PyQt5.QtWidgets import QLabel, QVBoxLayout, QWidget


class RecordsWidget(QWidget):
    def __init__(self, records):
        super().__init__()
        self.setWindowTitle("Статистика игры")
        self.layout = QVBoxLayout(self)
        self.display_records(records)
        
    def display_records(self, records):
        for record in records:
            self.add_record_label(record)

    def add_record_label(self, record):
        label_text = f"{record['name']}: {record['score']}"
        label = QLabel(label_text)
        self.layout.addWidget(label)
