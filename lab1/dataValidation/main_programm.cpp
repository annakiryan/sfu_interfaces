#include <iostream>
#include <string>
#include <regex>


using namespace std;

struct Date {
    int dd;
    int mm;
    int yyyy;
};

struct Patient {
    string passport;
    string name;
    Date birth_date;
    string phone;
    double temperature;
};

static bool check_data(string cin, bool(*val_func)(string)) // cin function
{
    if (val_func(cin)) return true;
    else return false;
}

#pragma region write_in_data

static void write_in_date(string date, Patient& patient)
{
    patient.birth_date.yyyy = stoi(date.substr(0, 4));
    patient.birth_date.mm = stoi(date.substr(5, 7));
    patient.birth_date.dd = stoi(date.substr(8));
}

static void write_in_temp(string temp, Patient& patient)
{
    patient.temperature = stod(temp);
}

#pragma endregion

#pragma region DataValidation

static bool ValidatePassport(string passport)
{
    regex passportPattern("\\d{2}\\s\\d{2}-\\d{6}");
    return regex_match(passport, passportPattern);
}

static bool ValidateDate(string date)
{
    regex datePattern("\\d{4}-\\d{2}-\\d{2}");
    bool format = regex_match(date, datePattern);

    if (!format) return false;

    int yyyy = stoi(date.substr(0, 4));
    int mm = stoi(date.substr(5, 7));
    int dd = stoi(date.substr(8));

    if (yyyy < 1900 || yyyy > 2024) return false;
    if (mm < 1 || mm > 12) return false;
    if (dd < 1 || dd > 31) return false;

    if ((mm == 4 || mm == 6 || mm == 9 || mm == 11) && dd > 30) return false;
    if (mm == 2) {
        bool isLeap = (yyyy % 4 == 0 && yyyy % 100 != 0) || (yyyy % 400 == 0);
        if (dd > (isLeap ? 29 : 28)) return false;
    }
    return true;
}

static bool ValidatePhone(string phone)
{
    regex phonePattern("(\\+7|8)\\(\\d{3}\\)\\s\\d{3}-(\\d{2}-\\d{2}|\\d{4})");
    return regex_match(phone, phonePattern);
}

static bool ValidateTemperature(string temp)
{
    regex tempPattern("(3[2-9]|4[0-2])\,\\d{2}");
    return regex_match(temp, tempPattern);
}

static bool ValidateName(string name)
{
    regex namePattern(R"([a-z][a-z'\s-]+)", regex_constants::icase);
    return regex_match(name, namePattern);
}

#pragma endregion

static void write_passport(Patient& patient)
{
    while (true)
    {
        cout << "Input your passport (format: ss ss-nnnnnn): ";
        getline(cin, patient.passport);

        if (check_data(patient.passport, ValidatePassport)) break;
        else cout << "Incorrect passport, try again.\n";
    }
}

static void write_name(Patient& patient)
{
    while (true)
    {
        cout << "Input your name: ";
        getline(cin, patient.name);

        if (check_data(patient.name, ValidateName)) break;
        else cout << "Incorrect name, try again.\n";
    }
}

static void write_date(Patient& patient)
{
    while (true)
    {
        string birthDate;

        cout << "Input the date of your birth (yyyy-mm-dd): ";
        getline(cin, birthDate);

        if (check_data(birthDate, ValidateDate))
        {
            write_in_date(birthDate, patient);
            break;
        }
        else cout << "Incorrect date, try again.\n";
    }
}

static void write_phone(Patient& patient)
{
    while (true) {
        cout << "Input your phone number (format: +X(XXX) XXX-XX-XX or X(XXX) XXX-XXXX): ";
        getline(cin, patient.phone);

        if (check_data(patient.phone, ValidatePhone)) break;
        else cout << "Incorrect phone number, try again.\n";
    }
}

static void write_temp(Patient& patient)
{
    while (true) {
        string temp;
        cout << "Input the temperature of your body (format: XX,XX): ";
        cin >> temp;

        if (check_data(temp, ValidateTemperature))
        {
            write_in_temp(temp, patient);
            break;
        }
        else cout << "Incorrect temperature, try again.\n";
    }
}


static Patient InputPatientData()
{
    Patient patient;

    write_passport(patient);
    write_name(patient);
    write_date(patient);
    write_phone(patient);
    write_temp(patient);

    return patient;
}


int main()
{
    Patient patient = InputPatientData();
    
    cout << "\nPatient's data:\n";
    cout << "Passport: " << patient.passport << endl;
    cout << "Name: " << patient.name << endl;
    cout << "Date of birth: " << patient.birth_date.yyyy << "-"
        << patient.birth_date.mm << "-" << patient.birth_date.dd << endl;
    cout << "Phone number: " << patient.phone << endl;
    cout << "Temperature: " << patient.temperature << endl;
}

