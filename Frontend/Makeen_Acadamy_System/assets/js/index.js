const sliders = document.querySelectorAll(".slider");
const sliderImages = Array.from(sliders).map((slider) =>
  slider.querySelectorAll("img")
);

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
}, 2000); // Adjust delay as needed



// Close Button

const form = document.getElementById("registerForm");
const modal = document.getElementById("thankYouModal");

form.addEventListener("submit", function (e) {
  e.preventDefault();
  modal.style.display = "flex";
  form.reset();
});


// Prevent click
function closeModal() {
  modal.style.display = "none";
  window.location.href = "/index.html"; // redirect to courses page
}
