function validateForm() {
    let isValid = true;

    // Reset error messages
    document.querySelectorAll('.error-message').forEach(function (error) {
        error.style.display = 'none';
    });

    // Validate Name
    const nameInput = document.querySelector('input[name="Name"]');
    if (!nameInput.value.trim()) {
        document.getElementById('nameError').style.display = 'block';
        isValid = false;
    }

    // Validate Email
    const emailInput = document.querySelector('input[name="Email"]');
    if (!emailInput.value.trim()) {
        document.getElementById('emailError').style.display = 'block';
        isValid = false;
    }

    // Validate Address
    const addressInput = document.querySelector('input[name="Address"]');
    if (!addressInput.value.trim()) {
        document.getElementById('addressError').style.display = 'block';
        isValid = false;
    }

    // Validate Phone Number
    const phoneInput = document.querySelector('input[name="PhoneNumber"]');
    if (!phoneInput.value.trim()) {
        document.getElementById('phoneError').style.display = 'block';
        isValid = false;
    }

    // Validate Message
    const messageInput = document.querySelector('textarea[name="Message"]');
    if (!messageInput.value.trim()) {
        document.getElementById('messageError').style.display = 'block';
        isValid = false;
    }

    return isValid;
}

// Attach event listener to the form
document.getElementById('yourForm').addEventListener('submit', function (event) {
    if (!validateForm()) {
        event.preventDefault(); // Prevent form submission if validation fails
    }
});