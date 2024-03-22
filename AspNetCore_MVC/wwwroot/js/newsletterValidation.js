const email = document.querySelector("#email");
const emailError = document.querySelector("#email-error");
const regEx = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;

email.addEventListener("keyup", (e) => {
    if (regEx.test(email.value) != true) {
        emailError.innerHTML = "Enter a valid email."
    } else {
        emailError.innerHTML = ""
    }
})