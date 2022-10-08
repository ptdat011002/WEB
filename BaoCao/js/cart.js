const btnCong = document.querySelectorAll(".cong");
const btnTru = document.querySelectorAll(".tru");
const amount = document.querySelectorAll(".amount > div");
const price = document.querySelectorAll(".table-product > div:nth-child(5)");
const total = document.querySelector(".total > div:last-child");
const pay1 = document.querySelector(".pay1 > div:last-child");
const pay2 = document.querySelector(".pay2 > div:last-child");
const input = document.querySelector("input");
const btn = document.querySelector(".voucher button");
const payProduct = document.querySelector(".pay-product");
const select = document.querySelectorAll(".select-tt");
const payAmount = document.querySelectorAll(".top-right-product > div:last-child");

console.log(btnCong);
console.log(btnTru);
console.log(amount);
console.log(price);
console.log(total);
console.log(btn);

var a;

for (let i = 0; i < btnCong.length; i++) {
  btnCong[i].addEventListener("click", function () {
    amount[i].innerText = Number(amount[i].innerText) + 1;
    if (i == 0) {
      price[i].innerText = Number(price[i].innerText) + 1785000;
    } else {
      price[i].innerText = Number(price[i].innerText) + 1170000;
    }

    a = Number(price[0].innerText) + Number(price[1].innerText);

    total.innerText = `${a} vnđ`;
    pay1.innerText = `${a} vnđ`;
    pay2.innerText = `${a} vnđ`;
    payProduct.innerText = `${a} vnđ`;

  });
  btnTru[i].addEventListener("click", function () {
    if (amount[i].innerText != 1) {
      amount[i].innerText = Number(amount[i].innerText) - 1;
      if (i == 0) {
        price[i].innerText = Number(price[i].innerText) - 1785000;
      } else {
        price[i].innerText = Number(price[i].innerText) - 1170000;
      }
      a = Number(price[0].innerText) + Number(price[1].innerText);

      total.innerText = `${a} vnđ`;
      pay1.innerText = `${a} vnđ`;
      pay2.innerText = `${a} vnđ`;
      payProduct.innerText = `${a} vnđ`;
    }
  });
}

for(let i = 0 ; i < 2 ; i++){
  select[i].addEventListener('click',function(){
    for(let j = 0 ; j < 2 ; j++){
      select[j].className = "select-tt";
    }
    select[i].className = "select-tt select-tt-border"
  })
}
