const listImg = document.querySelectorAll(".sub-img img");
const border = document.querySelectorAll(".sub-img > div");
const mainImg = document.querySelector(".main-img img");
const btnAdd = document.querySelector(".add-product > a");
console.log(listImg);
console.log(mainImg);

const listSize = document.querySelectorAll(".size > div");
console.log(listSize);

const currentIndex = 0;

function change_img(index) {
  console.log(listImg[index]);
  let img = listImg[index];
  mainImg.src = img.src;

  for (let i = 0; i < listImg.length; i++) {
    border[i].className = "";
  }

  border[index].className = "active";
}

for (let index = 0; index < listImg.length; index++) {
  listImg[index].addEventListener("click", (e) => change_img(index));
}

for (let index = 0; index < listSize.length; index++) {
  console.log(listSize[index]);
  listSize[index].onclick = function () {
    console.log(listSize[index]);
    for (let i = 0; i < listSize.length; i++) {
      listSize[i].className = "";
    }
    listSize[index].className = "active2";
  };
}

btnAdd.addEventListener("click", function () {
  alert("Thêm vào giỏ hàng thành công");
});

change_img(0);
