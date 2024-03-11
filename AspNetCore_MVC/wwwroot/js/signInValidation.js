emailInput = document.querySelector("#signInEmail")
emailSpan = document.querySelector("#signInSpan")

emailInput.addEventListener("keyup", () => {
    if (emailInput.value.length < 5) {
        emailSpan.innerHTML = "Enter a valid email address"
    }
    else {
        emailSpan.innerHTML = ""
    }
})