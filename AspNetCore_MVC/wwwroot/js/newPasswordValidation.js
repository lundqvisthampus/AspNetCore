const newPasswordInput = document.querySelector("#new-password")
const newPasswordSpan = document.querySelector("#new-password-span")

const confirmPasswordInput = document.querySelector("#confirm-new-password")
const confirmPasswordSpan = document.querySelector("#confirm-password-span")


const passwordRegex = /^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[A-Z])[a-zA-Z0-9!@#$%^&*]{8,}$/;


newPasswordInput.addEventListener("keyup", (e) => {
    if (passwordRegex.test(e.target.value) != true) {
        newPasswordSpan.innerHTML = "Password not strong enough"
        newPasswordSpan.classList.add("field-validation-error")
    }
    else {
        newPasswordSpan.innerHTML = ""
        newPasswordSpan.classList.remove("field-validation-error")
    }
})

confirmPasswordInput.addEventListener("keyup", (e) => {
    if (newPasswordInput.value !== e.target.value) {
        confirmPasswordSpan.innerHTML = "Does not match the new password"
        confirmPasswordSpan.classList.add("field-validation-error")
    }
    else {
        confirmPasswordSpan.innerHTML = ""
        confirmPasswordSpan.classList.remove("field-validation-error")
    }
})