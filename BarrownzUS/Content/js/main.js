(function ($) {
    "use strict";

    // Spinner
    var spinner = function () {
        setTimeout(function () {
            if ($('#spinner').length > 0) {
                $('#spinner').removeClass('show');
            }
        }, 1);
    };
    spinner();
    
    
    // Initiate the wowjs
    new WOW().init();


    // Sticky Navbar
    $(window).scroll(function () {
        if ($(this).scrollTop() > 45) {
            $('.navbar').addClass('sticky-top shadow-sm');
        } else {
            $('.navbar').removeClass('sticky-top shadow-sm');
        }
    });
    
    // Dropdown on mouse hover
    const $dropdown = $(".dropdown");
    const $dropdownToggle = $(".dropdown-toggle");
    const $dropdownMenu = $(".dropdown-menu");
    const showClass = "show";
    
    $(window).on("load resize", function() {
        if (this.matchMedia("(min-width: 992px)").matches) {
            $dropdown.hover(
            function() {
                const $this = $(this);
                $this.addClass(showClass);
                $this.find($dropdownToggle).attr("aria-expanded", "true");
                $this.find($dropdownMenu).addClass(showClass);
            },
            function() {
                const $this = $(this);
                $this.removeClass(showClass);
                $this.find($dropdownToggle).attr("aria-expanded", "false");
                $this.find($dropdownMenu).removeClass(showClass);
            }
            );
        } else {
            $dropdown.off("mouseenter mouseleave");
        }
    });


    // Facts counter
    $('[data-toggle="counter-up"]').counterUp({
        delay: 10,
        time: 2000
    });
    
    
    // Back to top button
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('.back-to-top').fadeIn('slow');
        } else {
            $('.back-to-top').fadeOut('slow');
        }
    });
    $('.back-to-top').click(function () {
        $('html, body').animate({scrollTop: 0}, 1500, 'easeInOutExpo');
        return false;
    });


    // Testimonials carousel
    $(".testimonial-carousel").owlCarousel({
        autoplay: true,
        smartSpeed: 1500,
        dots: true,
        loop: true,
        center: true,
        responsive: {
            0:{
                items:1
            },
            576:{
                items:1
            },
            768:{
                items:2
            },
            992:{
                items:3
            }
        }
    });


    // Vendor carousel
    $('.vendor-carousel').owlCarousel({
        loop: true,
        margin: 45,
        dots: false,
        loop: true,
        autoplay: true,
        smartSpeed: 1000,
        responsive: {
            0:{
                items:2
            },
            576:{
                items:4
            },
            768:{
                items:6
            },
            992:{
                items:8
            }
        }
    });
    
})(jQuery);




////let prev = document.querySelector('.prev');
//let prev = document.getElementById('prev');
////let next = document.querySelector('.next');
//let next = document.getElementById('next');
////let box = document.querySelector('.box');
//let box = document.getElementById("box")
//let items = document.querySelectorAll('.item');

//let isDragging = false;
//let startX, moveX, difference;

//// Next Button Functionality
//next.addEventListener('click', function () {
//    let item = document.querySelectorAll('.item');
//    box.style.transition = "transform 0.5s ease-in-out";
//    box.appendChild(item[0]);
//});

//// Prev Button Functionality
//prev.addEventListener('click', function () {
//    let item = document.querySelectorAll('.item');
//    box.style.transition = "transform 0.5s ease-in-out";
//    box.prepend(item[item.length - 1]);
//});

//// Auto-scroll Every 5 Seconds
//setInterval(() => {
//    let item = document.querySelectorAll('.item');
//    box.style.transition = "transform 0.5s ease-in-out";
//    box.appendChild(item[0]);
//}, 5000);


//box.addEventListener('mousedown', (e) => startDrag(e.clientX));
//box.addEventListener('touchstart', (e) => startDrag(e.touches[0].clientX));

//function startDrag(position) {
//    isDragging = true;
//    startX = position;
//    box.style.transition = "none"; 
//}

//box.addEventListener('mousemove', (e) => dragMove(e.clientX));
//box.addEventListener('touchmove', (e) => dragMove(e.touches[0].clientX));

//function dragMove(position) {
//    if (!isDragging) return;
//    moveX = position;
//    difference = moveX - startX;
//    box.style.transform = `translateX(${difference}px)`; 
//}


//box.addEventListener('mouseup', endDrag);
//box.addEventListener('mouseleave', endDrag);
//box.addEventListener('touchend', endDrag);

//function endDrag() {
//    if (!isDragging) return;
//    isDragging = false;
//    box.style.transition = "transform 0.5s ease-in-out";

//    if (difference < -50) {
//        let item = document.querySelectorAll('.item');
//        box.appendChild(item[0]);
//    } else if (difference > 50) {
//        let item = document.querySelectorAll('.item');
//        box.prepend(item[item.length - 1]);
//    }

//    box.style.transform = "translateX(0)";
//}


//Content hide and show 


const box1 = document.getElementById('Box_1');
const box2 = document.getElementById('Box_2');
const box3 = document.getElementById('Box_3');
const box4 = document.getElementById('Box_4');

const content1 = document.getElementById('content_1');
const content2 = document.getElementById('content_2');
const content3 = document.getElementById('content_3');
const content4 = document.getElementById('content_4');

function showContent(show, hide1, hide2, hide3) {
    show.style.display = 'block';
    show.style.opacity = 0;  
    let opacity = 0;


    let fadeIn = setInterval(() => {
        if (opacity >= 1) {
            clearInterval(fadeIn);
        } else {
            opacity += 0.1;
            show.style.opacity = opacity;
        }
    }, 50);  

    hide1.style.display = 'none';
    hide2.style.display = 'none';
    hide3.style.display = 'none';
}

// Event listeners
box1.addEventListener('click', () => showContent(content1, content2, content3, content4));
box2.addEventListener('click', () => showContent(content2, content1, content3, content4));
box3.addEventListener('click', () => showContent(content3, content1, content2, content4));
box4.addEventListener('click', () => showContent(content4, content1, content2, content3));

// Show content_1 by default
showContent(content1, content2, content3, content4);

