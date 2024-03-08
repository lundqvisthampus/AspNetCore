const emailInput = document.querySelector("#email-input")
const emailSpan = document.querySelector("#email-span")

const emailRegEx = /^[a-zA-Z0-9.]+@[a-zA-Z]+\.[a-zA-Z]{2,}$/

emailInput.addEventListener("keyup", (e) => {
    if (emailRegEx.test(e.target.value) != true) {
        emailSpan.innerHTML = "Invalid email address"
    }
    else {
        emailSpan.innerHTML = ""
    }
})

const firstnameInput = document.querySelector("#firstnameInput")
const firstnameSpan = document.querySelector("#firstnameSpan")

firstnameInput.addEventListener("keyup", (e) => {
    if (e.target.value.length < 2) {
        firstnameSpan.innerHTML = "Enter valid first name"
    }
    else {
        firstnameSpan.innerHTML = ""
    }
})

const lastnameInput = document.querySelector("#lastnameInput")
const lastnameSpan = document.querySelector("#lastnameSpan")

lastnameInput.addEventListener("keyup", (e) => {
    if (e.target.value.length < 2) {
        lastnameSpan.innerHTML = "Enter valid last name"
    }
    else {
        lastnameSpan.innerHTML = ""
    }
})