const btnScroll = document.getElementById("btnScroll");

window.onscroll = function () {
  scrollFunction()
};

function scrollFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
    btnScroll.style.display = "block";
  } else {
    btnScroll.style.display = "none";
  }
}

function scrollToTop() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

// /
const product = document.querySelectorAll(".product");
const btnAddToCart = document.querySelectorAll(".product .btn-addToCart");



for (let i = 0; i < product.length; i++) {
  product[i].addEventListener("mouseover", el => {
    btnAddToCart[i].style.display = "block";
  });
}

for (let i = 0; i < product.length; i++) {
  product[i].addEventListener("mouseout", el => {
    btnAddToCart[i].style.display = "none";
  });
}
btnAddToCart.forEach(e => e.addEventListener("click", function() {
  swal({
    title: "Đã thêm vào giỏ hàng",
    type: "success",
    showCancelButton: true,
    cancelButtonText: "Tiếp tục mua sắm",
    confirmButtonClass: "btn-info",
    confirmButtonText: "Đi đến giỏ hàng",
    closeOnConfirm: false,
  },
  function(){
    window.location.href = "/Cart/Index";
  });
}));
// /

const imgs = document.querySelectorAll(".img-item img");

imgs.forEach(element => element.addEventListener("click", changeImgDefault));

function changeImgDefault(e) {
  const source = e.target.getAttribute("src");
  const imgDefault = document.querySelector(".img-default-product");
  const imgClicked = document.querySelector(".is-clicked");
  imgClicked.classList.remove("is-clicked");
  imgDefault.setAttribute("src", source);
  e.target.classList.add("is-clicked");
}

const btnChooseSizes = document.querySelectorAll(".size-item");

btnChooseSizes.forEach(element => element.addEventListener("click", chooseSize));

function chooseSize(e) {
  const sizeSelected = document.querySelector(".size-selected");
  if (sizeSelected === null) {
    e.target.classList.add("size-selected");
  } else {
    sizeSelected.classList.remove("size-selected");
    e.target.classList.add("size-selected");
  }
}
// /
const btnIncreQty = document.querySelectorAll(".btn-incre");
const btnDecreQty = document.querySelectorAll(".btn-decre");
const qty = document.querySelectorAll(".quantity");

function checkQty() {
  for (let i = 0; i < qty.length; i++) {
    if (parseInt(qty[i].value) == 1) {
      btnDecreQty[i].disabled = true;
    } else {
      btnDecreQty[i].disabled = false;
    }
  }
};

checkQty();

function changeQty(e) {
  for(let i = 0; i < qty.length; i++){
    if(btnIncreQty[i] === e){
      qty[i].value = parseInt(qty[i].value) + 1;
    }

    if(btnDecreQty[i] === e){
      qty[i].value = parseInt(qty[i].value) - 1;
    }
  }
  checkQty();
}

// /
const delegate = document.getElementById("delegate");
delegate.addEventListener("change", function () {
  if (delegate.checked) {
    document.querySelector(".customer-delegate").style.display = "";
  } else {
    document.querySelector(".customer-delegate").style.display = "none";
  }
});