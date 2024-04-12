import os

def generate_text_field(name, quantity):
    fields = ''.join([f'<div><label>{name}:</label> <input type="text" name="{name}[]" /></div>' for _ in range(quantity)])
    return fields

def generate_password_field(name, quantity):
    fields = ''.join([f'<div><label>{name}:</label> <input type="password" name="{name}[]" /></div>' for _ in range(quantity)])
    return fields

def generate_email_field(name, quantity):
    fields = ''.join([f'<div><label>{name}:</label> <input type="email" name="{name}" /></div>' for _ in range(quantity)])
    return fields

def generate_dropdown_menu(name, options, quantity):
    dropdowns = ''.join([f'<div><label>{name}:</label> <select name="{name}">' + ''.join([f'<option value="{option}">{option}</option>' for option in options]) + '</select></div>' for _ in range(quantity)])
    return dropdowns

def generate_checkbox(name, value, quantity):
    checkboxes = ''.join([f'<div><label>{name}:</label> <input type="checkbox" name="{name}" value="{value}" />{value}</div>' for _ in range(quantity)])
    return checkboxes

def generate_date_picker(name, quantity):
    date_pickers = ''.join([f'<div><label>{name}:</label> <input type="date" name="{name}" /></div>' for _ in range(quantity)])
    return date_pickers

def main():
    form_elements = []

    while True:
        input_type = input("Enter the type of input you'd like to create (text/password/email/dropdown/checkbox/date), or 'stop' to finish: ").lower()

        if input_type == 'stop':
            break

        quantity = int(input(f"How many {input_type} fields would you like to add? "))

        if input_type == 'text':
            name = input("Enter the name for the text field: ")
            form_elements.append(generate_text_field(name, quantity))
        elif input_type == 'password':
            name = input("Enter the name for the password field: ")
            form_elements.append(generate_password_field(name, quantity))
        elif input_type == 'email':
            name = input("Enter the name for the email field: ")
            form_elements.append(generate_email_field(name, quantity))
        elif input_type == 'dropdown':
            name = input("Enter the name for the dropdown menu: ")
            options = input("Enter options separated by comma: ").split(',')
            form_elements.append(generate_dropdown_menu(name, options, quantity))
        elif input_type == 'checkbox':
            name = input("Enter the name for the checkbox: ")
            value = input("Enter the value for the checkbox: ")
            form_elements.append(generate_checkbox(name, value, quantity))
        elif input_type == 'date':
            name = input("Enter the name for the date picker: ")
            form_elements.append(generate_date_picker(name, quantity))
        else:
            print("Invalid input type. Please try again.")

    html_folder = os.path.join(os.getcwd(), "HTMLForms")
    os.makedirs(html_folder, exist_ok=True)

    with open(os.path.join(html_folder, "SendForm.html"), "w") as f:
        f.write(f'<form action="HandleRequest.php" method="post">\n')
        for element in form_elements:
            f.write(element + '<br>\n')  # Add line break after each element
        f.write('<input type="submit" value="Send">\n')  # Add send button
        f.write("</form>")

if __name__ == "__main__":
    main()
