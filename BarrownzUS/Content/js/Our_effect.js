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

    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;
    let number = document.getElementById("number").value;
    let option = document.getElementById("option").value;
    let message = document.getElementById("message").value;

    let valid = true;

    let name_error = document.getElementById("name_error");
    let email_error = document.getElementById("email_error");
    let number_error = document.getElementById("number_error");
    let option_error = document.getElementById("option_error");
    let message_error = document.getElementById("message_error");

    name_error.textContent = "";
    email_error.textContent = "";
    number_error.textContent = "";
    option_error.textContent = "";
    message_error.textContent = "";


    if (name.trim() === "") {
        name_error.textContent = "Please enter your name";
        valid = false;
    }

    let emailPattern = /^[a-zA-Z0-9._-]+@@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    if (email === "" && !email.match(emailPattern)) {
        email_error.textContent = "Please enter valid email";
        valid = false;
    }

    if (option === "") {
        option_error.textContent = "Please select option";
        valid = false;
    }

    if (number === "" || number.length < 10) {
        number_error.textContent = "Please enter a valid number";
        valid = false;
    }


    if (message === "") {
        message_error.textContent = "please write message";
        valid = false;
    }

    return valid;

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