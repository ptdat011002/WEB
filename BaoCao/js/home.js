const btnUp = document.querySelector(".direct");

window.addEventListener("scroll", function () {
    if (window.pageYOffset >= 300) {
      btnUp.className = "direct hide";
    } else {
      btnUp.className = "direct";
    }
});
