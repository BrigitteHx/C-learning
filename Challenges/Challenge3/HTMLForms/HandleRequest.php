<?php

// Check if the form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Initialize array to store form data
    $data = array();

    // Check if any form fields are submitted
    if (!empty($_POST)) {
        // Loop through submitted form fields
        foreach ($_POST as $field_name => $field_value) {
            // Check if field value is not empty
            if (!empty($field_value)) {
                // Check if field is an array (indicating multiple instances)
                if (is_array($field_value)) {
                    // If field is an array, iterate over its values
                    foreach ($field_value as $value) {
                        // Add field name and value to data array
                        $data[$field_name][] = $value;
                    }
                } else {
                    // If field is not an array, add it directly to data array
                    $data[$field_name] = $field_value;
                }
            }
        }

        // Check if any data is collected
        if (!empty($data)) {
            // Save data to JSON file
            $file = 'userData.json';
            file_put_contents($file, json_encode($data, JSON_PRETTY_PRINT));

            // Display data in JSON format
            echo json_encode($data, JSON_PRETTY_PRINT);
        } else {
            // Display error message if no data provided
            echo "Error: No data submitted.";
        }
    } else {
        // Display error message if no form fields submitted
        echo "Error: No form fields submitted.";
    }
} else {
    // Display error message if form is not submitted
    echo "Error: Form submission method not allowed.";
}

?>
