from enum import Flag
from recognizers_text import Culture, Recognizer, Model
from .models import NumberModel, OrdinalModel, PercentModel

class NumberOptions(Flag):
    NONE = 0

class NumberRecognizer(Recognizer[NumberOptions]):
    def __init__(self, target_culture: str=None, options: NumberOptions=NumberOptions.NONE, lazy_initialization: bool=True):
        super().__init__(target_culture, options, lazy_initialization)

    def initialize_configuration(self):
        self.register_model("NumberModel", Culture.English, lambda options: NumberModel(
            None,
            None
        ))
        self.register_model("OrdinalModel", Culture.English, lambda options: OrdinalModel(
            None,
            None
        ))
        self.register_model("PercentModel", Culture.English, lambda options: PercentModel(
            None,
            None
        ))

    def get_number_model(self, culture: str=None, fallback_to_default_culture: bool=True) -> Model:
        return self.get_model("NumberModel", culture, fallback_to_default_culture)