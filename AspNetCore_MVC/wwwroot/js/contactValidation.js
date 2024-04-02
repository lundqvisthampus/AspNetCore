const nameSpan = document.querySelector("#fullNameSpan")
const nameInput = document.querySelector("#fullNameInput")

const emailSpan = document.querySelector("#emailSpan")
const emailInput = document.querySelector("#emailInput")

const messageSpan = document.querySelector("#messageSpan")
const messageInput = document.querySelector("#messageInput")

const regEx = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;

nameInput.addEventListener("keyup", () => {
    if (nameInput.value.length < 4) {
        nameSpan.innerHTML = "Enter a valid name"
    }
    else {
        nameSpan.innerHTML = ""
    }
})

emailInput.addEventListener("keyup", () => {
    if (regEx.test(emailInput.value) == false) {
        emailSpan.innerHTML = "Enter a valid email address"
    }
    else {
        emailSpan.innerHTML = ""
    }
})

messageInput.addEventListener("keyup", () => {
    if (messageInput.value.length < 20) {
        messageSpan.innerHTML = "Message is too short"
    }
    else {
        messageSpan.innerHTML = ""
    }
})