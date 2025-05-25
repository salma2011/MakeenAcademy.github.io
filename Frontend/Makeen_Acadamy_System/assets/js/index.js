const images = document.querySelectorAll("#imageSlider img");
const sliderButtons = document.getElementById("sliderButtons");
let currentIndex = 0;

images.forEach((_, index) => {
  const btn = document.createElement("button");
  btn.addEventListener("click", () => {
    images[currentIndex].classList.remove("active");
    sliderButtons.children[currentIndex].classList.remove("active");
    currentIndex = index;
    images[currentIndex].classList.add("active");
    sliderButtons.children[currentIndex].classList.add("active");
  });
  sliderButtons.appendChild(btn);
});

// Set the first button as active
sliderButtons.children[0].classList.add("active");




const swiper = new Swiper(".mySwiper", {
  slidesPerView: 1,
  spaceBetween: 20,
  loop: true,
  pagination: {
    el: ".swiper-pagination",
    clickable: true,
  },
  navigation: {
    nextEl: ".swiper-button-next",
    prevEl: ".swiper-button-prev",
  },
  breakpoints: {
    640: {
      slidesPerView: 1,
    },
    768: {
      slidesPerView: 2,
    },
  },
});
