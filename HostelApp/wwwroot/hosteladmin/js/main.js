let right = document.getElementById("right");
let left = document.getElementById("left");
let images = document.querySelector(".images");

right.addEventListener("click", SlideRight);
left.addEventListener("click", SlideLeft);

function SlideRight() {
    let active = document.querySelector(".active");
    active.classList.remove("active");
    if (active.nextElementSibling != null) {
        active.nextElementSibling.classList.add("active");
    }
    else {
        images.firstElementChild.classList.add("active");
    }
}
function SlideLeft() {
    let active = document.querySelector(".active");
    active.classList.remove("active");
    if (active.previousElementSibling != null) {
        active.previousElementSibling.classList.add("active");
    }
    else {
        images.lastElementChild.classList.add("active");
    }
}



