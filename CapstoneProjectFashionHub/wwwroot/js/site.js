// contact us
window.setTimeout(function () {
    $(".alert").fadeTo(500, 0).slideUp(500, function () {
        $(this).remove();
    });
}, 3000);

// toggle active pertanyaan
document.addEventListener("DOMContentLoaded", function () {
    const faqItems = document.querySelectorAll(".faq-item h3");
    faqItems.forEach((item) => {
        item.addEventListener("click", function () {
            const parent = this.parentElement;
            parent.classList.toggle("active");
        });
    });
});

// button show more and hidden
function showMore() {
    document.getElementById('hidden').style.display = "block"
    document.getElementById('btn-show').style.display = "none"
    document.getElementById('btn-hidden').style.display ="inline-block"
}

function showLess() {
    document.getElementById('hidden').style.display = "none"
    document.getElementById('btn-show').style.display = "inline-block"
    document.getElementById('btn-hidden').style.display = "none"
}

// animasi produk
let slideIndex = 0;
showSlides();

function showSlides() {
    let slides = document.getElementsByClassName("slide");
    for (let i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex++;
    if (slideIndex > slides.length) { slideIndex = 1 }
    slides[slideIndex - 1].style.display = "block";
    setTimeout(showSlides, 10000);
}

document.querySelector('.prev').addEventListener('click', function () {
    slideIndex -= 2;
    showSlides();
});

document.querySelector('.next').addEventListener('click', function () {
    showSlides();
});
