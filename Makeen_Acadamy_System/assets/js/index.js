const hero = document.querySelector(".hero");
const images = [
  "./assets/imgs/slider/s3.jpg",
  "./assets/imgs/slider/s21.jpg",
  "./assets/imgs/slider/s1.jpg",
];

let index = 0;

function changeBackground() {
  hero.style.backgroundImage = `url('${images[index]}')`;
  index = (index + 1) % images.length;
}

// Initial background
if (hero) {
  changeBackground();
  // Change every 5 seconds
  setInterval(changeBackground, 5000);
}

const sliders = document.querySelectorAll(".slider");
const sliderImages = Array.from(sliders).map((slider) =>
  slider.querySelectorAll("img")
);

if (sliders.length > 0) {
  const indices = Array(sliders.length).fill(0); // Current image index for each slider
  let currentSlider = 0; // Start from first slider

  function updateSlider(sliderIndex, imgIndex) {
    const images = sliderImages[sliderIndex];
    images.forEach((img, i) => {
      img.classList.toggle("active", i === imgIndex);
    });
  }

  // Initial setup
  sliders.forEach((_, i) => updateSlider(i, 0));

  setInterval(() => {
    // Update current slider
    indices[currentSlider] =
      (indices[currentSlider] + 1) % sliderImages[currentSlider].length;
    updateSlider(currentSlider, indices[currentSlider]);

    // Move to next slider for next tick
    currentSlider = (currentSlider + 1) % sliders.length;
  }, 2000);
}

// Modal functionality
const form = document.getElementById("registerForm");
const modal = document.getElementById("thankYouModal");

if (form && modal) {
  form.addEventListener("submit", function (e) {
    e.preventDefault();
    modal.style.display = "flex";
    form.reset();
  });

  // Close modal function
  function closeModal() {
    modal.style.display = "none";
    window.location.href = "./index.html";
  }

  // Add event listeners for closing modal
  const closeBtn = modal.querySelector(".close-btn");
  const closeButton = modal.querySelector("button");

  if (closeBtn) {
    closeBtn.addEventListener("click", closeModal);
  }

  if (closeButton) {
    closeButton.addEventListener("click", closeModal);
  }

  // Close modal when clicking outside
  modal.addEventListener("click", function (e) {
    if (e.target === modal) {
      closeModal();
    }
  });
}
