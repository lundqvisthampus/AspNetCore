const header = document.querySelector("header")
const url = window.location.pathname

const toggleDarkMode = () => {
    const body = document.querySelector('body');
    const darkModeEnabled = body.classList.toggle('dark-mode');
    localStorage.setItem('darkModeEnabled', darkModeEnabled);

    const logo = document.querySelector("#logotype");
    if (darkModeEnabled) {
        logo.setAttribute("src", "/images/solid.svg");
    } else {
        logo.setAttribute("src", "/images/logotype.svg");
    }

    if (darkModeEnabled && url == "/Contact") {
        header.style.backgroundColor = "#0f121e"
    }
    else if (darkModeEnabled && url != "/Contact") {
        header.style.backgroundColor = "#0B0F19"
    }
    else if (darkModeEnabled == false && url == "/Contact") {
        header.style.backgroundColor = "#F3F6FF"
    }
    else {
        header.style.backgroundColor = "#FFFFFF"
    }
}

window.addEventListener("DOMContentLoaded", () => {
    const body = document.querySelector('body');
    const darkModeEnabled = localStorage.getItem('darkModeEnabled')

    if (darkModeEnabled === "true") {
        body.classList.add('dark-mode');
        document.getElementById("darkModeToggle").checked = true;
        document.querySelector("#logotype").setAttribute("src", "/images/solid.svg");
        if (url === "/Contact") {
            header.style.backgroundColor = "#0f121e";
        } else {
            header.style.backgroundColor = "#0B0F19";
        }
    }
    else {
        body.classList.remove('dark-mode');
        document.getElementById("darkModeToggle").checked = false;
        document.querySelector("#logotype").setAttribute("src", "/images/logotype.svg");
        header.style.backgroundColor = "#FFFFFF"
        if (url === "/Contact") {
            header.style.backgroundColor = "#F3F6FF";
        } else {
            header.style.backgroundColor = "#FFFFFF";
        }
    }
})


const toggleMenu = () => {
    document.getElementById('menu').classList.toggle('hide');
}

const checkScreenSize = () => {
    if (window.innerWidth >= 992) {
        document.getElementById('menu').classList.add('hide');
    }
}

window.addEventListener('resize', checkScreenSize);