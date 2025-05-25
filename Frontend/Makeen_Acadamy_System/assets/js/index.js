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
}, 3000); // Adjust delay as needed

// const form = document.getElementById("registerForm");
//     const modal = document.getElementById("thankYouModal");

//     form.addEventListener("submit", function (e) {
//       e.preventDefault(); // prevent actual form submission
//       modal.style.display = "flex";
//       form.reset(); // optional: reset the form after submission
//     });

//     function closeModal() {
//       modal.style.display = "none";
//     }

//     // Optional: close modal when clicking outside content
//     window.onclick = function (event) {
//       if (event.target == modal) {
//         modal.style.display = "none";
//       }
//     }

// const form = document.getElementById("registerForm");
// const modal = document.getElementById("thankYouModal");

// form.addEventListener("submit", function (e) {
//   e.preventDefault(); // prevent actual form submission
//   modal.style.display = "flex";
//   form.reset(); // optional: reset the form after submission
// });

// function closeModal() {
//   modal.style.display = "none";
//   window.location.href = "/index.html"; // redirect after closing modal
// }

// // Optional: close modal when clicking outside content
// window.onclick = function (event) {
//   if (event.target == modal) {
//     modal.style.display = "none";
//   }
// };

// // Optional: close modal when clicking outside content
// window.onclick = function (event) {
//   if (event.target == modal) {
//     closeModal();
//   }
// };

const form = document.getElementById("registerForm");
const modal = document.getElementById("thankYouModal");

form.addEventListener("submit", function (e) {
  e.preventDefault();
  modal.style.display = "flex";
  form.reset();
});

function closeModal() {
  modal.style.display = "none";
  window.location.href = "/index.html"; // redirect to courses page
}

// NO window.onclick handler here, so clicking outside modal-content won't close modal
