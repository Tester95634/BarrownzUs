//This js image hover effect start here
window.addEventListener('load', () => {
    let el = document.querySelector('.dev');

    const height = el.clientHeight;
    const width = el.clientWidth;

    el.addEventListener('mousemove', handleMove);
    el.addEventListener('mouseleave', resetTransform);

    function handleMove(e) {
        const xVal = e.layerX;
        const yVal = e.layerY;

        const yRotation = 20 * ((xVal - width / 2) / width);
        const xRotation = -20 * ((yVal - height / 2) / height);

        const string = 'perspective(500px) scale(1.01) rotateX(' + xRotation + 'deg) rotateY(' + yRotation + 'deg)';

        el.style.transform = string;
    }

    function resetTransform() {
        el.style.transform = 'perspective(500px) scale(1) rotateX(0) rotateY(0)';
    }
});

//This js image hover effect end here

//Text hover letter zooming effect for About Page
document.addEventListener("DOMContentLoaded", function () {
    let heading = document.querySelector(".Hover_text"); 
    let newHtml = "";

    heading.childNodes.forEach(node => {
        if (node.nodeType === 3) { 
            let text = node.nodeValue.trim();
            for (let char of text) {
                if (char === " ") {
                    newHtml += "&nbsp;";
                } else {
                    newHtml += `<span class="scale-letter">${char}</span>`;
                }
            }
        } else {
            newHtml += node.outerHTML; 
        }
    });

    heading.innerHTML = newHtml; 
});

//This js for about page
// animation js
var radius = 80;

TweenLite.set(".ball", {
    xPercent: -50,
    yPercent: -50,
    x: -radius,
    y: -radius
});

TweenMax.to(".ball", 1.2, {
    y: radius,
    ease: Sine.easeInOut,
    repeat: -1,
    yoyo: true
});

TweenMax.to(".ball", 1, {
    x: radius,
    ease: Sine.easeInOut,
    repeat: -1,
    yoyo: true
}).progress(0.5);




//The validation for form

function validate() {
    let isValid = true;

    // Clear all previous error messages
    document.getElementById("name_error").innerText = "";
    document.getElementById("email_error").innerText = "";
    document.getElementById("number_error").innerText = "";
    document.getElementById("option_error").innerText = "";
    document.getElementById("message_error").innerText = "";

    // Get values
    const name = document.getElementById("name").value.trim();
    const email = document.getElementById("email").value.trim();
    const number = document.getElementById("number").value.trim();
    const option = document.getElementById("option").value;
    const message = document.getElementById("message").value.trim();

    // Name validation
    if (name === "") {
        document.getElementById("name_error").innerText = "Name is  required.";
        isValid = false;
    }

    // Email validation
    const emailPattern = /^[^@\s]+@[^@\s]+\.[^@\s]+$/;
    if (email === "") {
        document.getElementById("email_error").innerText = "Email is required.";
        isValid = false;
    } else if (!emailPattern.test(email)) {
        document.getElementById("email_error").innerText = "Enter a valid email address.";
        isValid = false;
    }

    // Number validation
    if (number === "") {
        document.getElementById("number_error").innerText = "Phone number is required.";
        isValid = false;
    } else if (number.length < 10) {
        document.getElementById("number_error").innerText = "Enter a valid phone number.";
        isValid = false;
    }

    if (option === "" || option === "Select A Service") {
        document.getElementById("option_error").innerText = "Please select a service.";
        isValid = false;
    }


    // Message validation
    if (message === "") {
        document.getElementById("message_error").innerText = "Message is required.";
        isValid = false;
    }

    return isValid;
}


//This js work for Nav bar on scroll
//Url find add css
document.addEventListener('DOMContentLoaded', function () {
    if (document.title === 'Web Development & Digital Marketing Experts | Barrownz Group') {
        var elements = document.querySelectorAll('.navbar-dark');
        elements.forEach(function (element) {
            element.style.position = 'absolute';
            element.style.position = 'fixed';
        });

    }
});

//this js work on two image in navbar by default show white logo on scroll show black image
$(document).ready(function () {
    // Function to toggle images based on page title and scroll position
    function toggleImages() {
        var scrollPosition = $(window).scrollTop();
        var pageTitle = document.title;

        if (pageTitle === 'Web Development & Digital Marketing Experts | Barrownz Group') {
            if (scrollPosition > 45) {
                $('.first').show();
                $('.second_image').hide();
            } else {
                $('.first').hide();
                $('.second_image').show();
            }
        }
    }

    // Initial check on page load
    toggleImages();

    // Js working on sticky navbar ko show karne mein
    $(window).scroll(function () {
        toggleImages();
        // Toggle navbar sticky class based on scroll position
        if ($(this).scrollTop() > 45) {
            $('.navbar').addClass('sticky-top shadow-sm');
        } else {
            $('.navbar').removeClass('sticky-top shadow-sm');
        }
    });
});

//Typed Js Animation
var typed = new Typed('#element', {
    strings: ['Development',
        ' Barrownz Group.'],
    typeSpeed: 110,
    startDelay: 1000,
    cursorChar: '!',
    loop: true,
    backSpeed: 80,
});

var typed = new Typed('#DM', {
    strings: ['Digital Marketing',
        ' Barrownz Group'],
    typeSpeed: 110,
    startDelay: 1000,
    cursorChar: '!',
    loop: true,
    backSpeed: 80,
});

var typed = new Typed('#Gd', {
    strings: ['Graphic Design.',
        ' Barrownz Group'],
    typeSpeed: 110,
    startDelay: 1000,
    cursorChar: '!',
    loop: true,
    backSpeed: 80,
});

var typed = new Typed('#seo', {
    strings: ['SEO',
        ' (SEO) Search Engine Optimization.'],
    typeSpeed: 110,
    startDelay: 1000,
    cursorChar: '!',
    loop: true,
    backSpeed: 80,
});


//bottom top btn
$(window).scroll(function () {
    let buttons = document.getElementById("bottom-top");
    if ($(this).scrollTop() > 100) {
        buttons.style.display = 'block';
    } else {
        buttons.style.display = 'none';
    }
});
