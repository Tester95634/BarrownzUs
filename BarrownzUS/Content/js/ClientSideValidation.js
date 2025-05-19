const contactFormValidator = document.getElementById("contactForm");

if (contactFormValidator) {

contactFormValidator.addEventListener("submit", function (e) {
    var isValid = true;
    var form = e.target;
    var inputs = form.querySelectorAll("input, select, textarea");

    // Clear previous error messages
    form.querySelectorAll(".error-message").forEach(function (el) {
        el.textContent = "";
    });

    inputs.forEach(function (input) {
        var errorDiv = input.nextElementSibling;
        if (input.type !== "submit") {
            if (input.name === "Service" && input.value === "") {
                errorDiv.textContent = "Please select a service.";
                isValid = false;
            } else if (input.value.trim() === "") {
                errorDiv.textContent = "This field is required.";
                isValid = false;
            } else if (input.name === "Email" && !/^\S+@\S+\.\S+$/.test(input.value)) {
                errorDiv.textContent = "Please enter a valid email address.";
                isValid = false;
            }
        }
    });

    if (!isValid) {
        e.preventDefault(); // Prevent form submission if validation fails
    }
});

}