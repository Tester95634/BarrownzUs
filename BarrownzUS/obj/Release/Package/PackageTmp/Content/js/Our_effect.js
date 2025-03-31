
//for seo southacarolina page 
let el = document.querySelector('.dev')


const height = el.clientHeight
const width = el.clientWidth


el.addEventListener('mousemove', handleMove)


function handleMove(e) {

    const xVal = e.layerX

    const yVal = e.layerY


    const yRotation = 20 * ((xVal - width / 2) / width)


    const xRotation = -20 * ((yVal - height / 2) / height)


    const string = 'perspective(500px) scale(1.01) rotateX(' + xRotation + 'deg) rotateY(' + yRotation + 'deg)'


    el.style.transform = string
}


el.addEventListener('mouseout', function () {
    el.style.transform = 'perspective(500px) scale(1) rotateX(0) rotateY(0)'
})


el.addEventListener('mousedown', function () {
    el.style.transform = 'perspective(500px) scale(0.9) rotateX(0) rotateY(0)'
})


el.addEventListener('mouseup', function () {
    el.style.transform = 'perspective(500px) scale(1.1) rotateX(0) rotateY(0)'
})



//Text hover letter zooming effect
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

//validation form
function validate() {

    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;
    let option = document.getElementById("option").value;
    let message = document.getElementById("message").value;

    let valid = true;

    let name_error = document.getElementById("name_error");
    let email_error = document.getElementById("email_error");
    let option_error = document.getElementById("option_error");
    let message_error = document.getElementById("message_error");

    name_error.textContent = "";
    email_error.textContent = "";
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

    if (message === "") {
        message_error.textContent = "please write message";
        valid = false;
    }
    if (valid) {
        alert("Your form has been submit");

    }

    return valid;

}

let text = document.querySelectorAll(".text-danger")

text.forEach((element) => {
    setTimeout(() => {
        element.style.display = "none";
    }, 10000)
})


